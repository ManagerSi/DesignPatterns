using DesignPatternsDemo.Creational.原型模式.V1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatternsDemo.Creational.原型模式.V1
{
    [Serializable]
    public class Prototype : ICloneable
    {
        public Prototype() : this(null, null) { }
        public Prototype(string name, Address address)
        {
            this.PrototypeName = name;
            this.Address = address;
        }
        public string PrototypeName { get; set; }
        public Address Address { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Show()
        {
            Console.WriteLine($"name:{this.PrototypeName}, address city:{this.Address?.City}");
        }
        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public Prototype ShallowClone()
        {
            return Clone() as Prototype;
        }

        /// <summary>
        /// System.Runtime.Serialization
        /// </summary>
        /// <returns></returns>
        public T DeepCloneByBin<T>(T obj) where T:class
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, this);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as T;
            }
        }

        /// <summary>
        /// System.XML.Serialization
        /// </summary>
        /// <returns></returns>
        public T DeepCloneByXml<T>(T obj) where T : class
        {
            using (Stream objectStream = new MemoryStream())
            {
                XmlSerializer xmlserialize = new XmlSerializer(typeof(T));
                xmlserialize.Serialize(objectStream, this);
                objectStream.Seek(0, SeekOrigin.Begin);
                return xmlserialize.Deserialize(objectStream) as T;
            }
        }
        /// <summary>
        /// 利用反射实现深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tSource"></param>
        /// <returns></returns>
        public object DeepCopyByReflection(object obj)
        {
            Type type = obj.GetType();
            //对于没有公共无参构造函数的类型此处会报错
            object returnObj = Activator.CreateInstance(type);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < fields.Length; i++)
            {
                FieldInfo field = fields[i];
                var fieldValue = field.GetValue(obj);
                if (fieldValue == null) continue;

                ///值类型，字符串，枚举类型直接把值复制，不存在浅拷贝
                if (fieldValue.GetType().IsValueType || fieldValue.GetType().Equals(typeof(System.String)) || fieldValue.GetType().IsEnum)
                {
                    field.SetValue(returnObj, fieldValue);
                }
                else
                {
                    field.SetValue(returnObj, DeepCopyByReflection(fieldValue));
                }
            }

            //属性
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                var propertyValue = property.GetValue(obj);
                if (propertyValue == null) continue;
                if (propertyValue.GetType().IsValueType || propertyValue.GetType().Equals(typeof(System.String)) || propertyValue.GetType().IsEnum)
                {
                    property.SetValue(returnObj, propertyValue);
                }
                else
                {
                    property.SetValue(returnObj, DeepCopyByReflection(propertyValue));
                }
            }

            return returnObj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tSource"></param>
        /// <returns></returns>
        public T DeepCopyByNewtonSoft<T>(T tSource)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(tSource));
        }
        

    }
}
