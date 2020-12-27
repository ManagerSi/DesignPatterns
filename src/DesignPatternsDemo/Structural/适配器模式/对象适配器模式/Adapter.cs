using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.对象适配器模式
{
    public class Adapter:Target
    {
        /// <summary>
        /// 适配器引用适配者的对象，所以叫对象适配器
        /// </summary>
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void DoSomething()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法1");
            _adaptee.DoSomethingSepecial();
        }

        public void DoSomething2()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法2");
            _adaptee.DoSomethingSepecial2();
        }
    }
}
