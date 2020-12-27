using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.缺省适配器模式
{
    /// <summary>
    /// target 方法较多，但并非全都需要，定义AbstractAdapter使用默认实现所有方法
    /// 定义adapter类继承AbstractAdapter类，覆写需要的方法
    /// </summary>
    public class Adapter : AbstractAdapter
    {
        //同时拥有对目标类及适配者类的引用
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public override void DoSomething()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法1");
            _adaptee.DoSomethingSepecial();
        }

        public override void DoSomething2()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法2");
            _adaptee.DoSomethingSepecial2();
        }
    }
}
