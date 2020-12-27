using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.对象适配器模式
{
    public class Adaptee
    {
        public void DoSomethingSepecial()
        {
            Console.WriteLine($"{typeof(Adaptee)} 适配者的特殊方法1");
        }

        public void DoSomethingSepecial2()
        {
            Console.WriteLine($"{typeof(Adaptee)} 适配者的特殊方法2");
        }
    }
}
