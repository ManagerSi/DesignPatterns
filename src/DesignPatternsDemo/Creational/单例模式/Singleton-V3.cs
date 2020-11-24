using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.单例模式
{
    /// <summary>
    /// 内部类
    /// </summary>
    public class Singleton_V3
    {
        private Singleton_V3()
        {
            Console.WriteLine("Singleton_V3 Created!");
        }

        public static Singleton_V3 GetInstance()
        {
            return InnerClass._singletonV3;
        }

        private static class InnerClass
        {
            public static Singleton_V3 _singletonV3 = new Singleton_V3();
        }
    }
}
