using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component
{
    public class TextBox : Component
    {
        public override void Display()
        {
            Console.WriteLine($"{this.GetType().Name} 显示文本框");
        }
    }
}
