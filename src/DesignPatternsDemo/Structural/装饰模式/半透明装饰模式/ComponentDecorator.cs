using System;
using System.Collections.Generic;
using System.Text;
using c = DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component;

namespace DesignPatternsDemo.Structural.装饰模式.半透明装饰模式
{
    /// <summary>
    /// 装饰器基类
    /// 半透明含义：子类创建父类之外的方法，客户端可单独调用这些方法，但无法嵌套
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
