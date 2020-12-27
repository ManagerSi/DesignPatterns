using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.类适配器模式
{
    /// <summary>
    /// 适配器继承适配者类，所以叫类适配器
    /// 此方法限制较多
    /// 1，需要被继承的类不是sealed，即可被继承
    /// 2. 需要调用方是接口，若是类，则因继承了适配者而无法继承目标类
    /// </summary>
    public class Adapter:Adaptee,Target
    {
        public void DoSomething()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法1");
            base.DoSomethingSepecial();
        }

        public void DoSomething2()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法2");
            base.DoSomethingSepecial2();
        }
    }
}
