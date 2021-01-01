using System;
using System.Collections.Generic;
using System.Text;
using c = DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component;

namespace DesignPatternsDemo.Structural.装饰模式.透明装饰模式
{
    /// <summary>
    /// 装饰器基类
    /// 透明含义：通过继承方式，可以实现‘无限’嵌套以增加不同的功能
    /// </summary>
    public class ComponentDecorator : c.Component
    {
        /// <summary>
        /// 保持原有对象的引用
        /// </summary>
        private readonly c.Component _component;

        public ComponentDecorator(c.Component component)
        {
            _component = component;
        }

        /// <summary>
        /// 子类通过覆写此方法增加不同的功能
        /// </summary>
        public override void Display()
        {
            _component.Display();
        }
    }
}
