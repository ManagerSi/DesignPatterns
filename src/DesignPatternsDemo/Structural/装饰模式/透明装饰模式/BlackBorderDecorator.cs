using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.装饰模式.透明装饰模式
{
    /// <summary>
    /// 边框装饰器
    /// </summary>
    public class BlackBorderDecorator : ComponentDecorator
    {
        public BlackBorderDecorator(Component.Component component) : base(component)
        {
        }

        /// <summary>
        /// 子类重写此方法增加功能
        /// </summary>
        public override void Display()
        {
            //增加功能
            SetBlackBorder();

            //父类原有功能
            base.Display();
        }

        private void SetBlackBorder()
        {
            Console.WriteLine($"{this.GetType().Name} 设置黑色边框");
        }
    }
}
