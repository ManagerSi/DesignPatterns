using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.双向适配器模式
{
    /// <summary>
    /// 适配器继承适配者类，所以叫类适配器
    /// 此方法限制较多
    /// </summary>
    public class Adapter
    {
        //同时拥有对目标类及适配者类的引用
        private Adaptee _adaptee;
        private Target _target;
        
        public void SetAdaptee(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void SetTarget(Target target)
        {
            _target = target;
        }

        public void DoAdapterSomething()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用适配者方法1");
            _adaptee.DoSomethingSepecial();
        }

        public void DoTargetSomething2()
        {
            Console.WriteLine($"{typeof(Adapter)} 适配器调用Target方法2");
            _target.DoSomething2();
        }
    }
}
