using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.单例模式
{
    /// <summary>
    /// 懒汉模式
    /// </summary>
    public class Singleton_V2
    {
        private static Singleton_V2 _singletonV2;

        private static object _lock = new object();

        private Singleton_V2()
        {
            Console.WriteLine("Singleton_V2 Created!");
        }

        public static Singleton_V2 GetInstance()
        {
            if(_singletonV2==null)
                lock(_lock)
                    if(_singletonV2 == null)
                        _singletonV2 = new Singleton_V2();
            
            return _singletonV2;
        }
    }
}
