using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.单例模式
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class Singleton_V1
    {
        private static Singleton_V1 model = new Singleton_V1();

        private Singleton_V1()
        {
            Console.WriteLine("Singleton_V1 Created!");
        }

        public static Singleton_V1 GetInstance()
        {
            return model;
        }
    }
}
