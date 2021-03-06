﻿using System;
using System.Collections.Generic;
using System.Text;
using c = DesignPatternsDemo.Structural.装饰模式.透明装饰模式.Component;

namespace DesignPatternsDemo.Structural.装饰模式.半透明装饰模式
{
    /// <summary>
    /// 滚动条装饰器
    /// </summary>
    public class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(c.Component component) : base(component)
        {
        }

        /// <summary>
        /// 子类重写此方法增加功能
        /// </summary>
        public override void Display()
        {
            //增加功能
            SetScrollBar();

            //父类原有功能
            base.Display();
        }

        private void SetScrollBar()
        {
            Console.WriteLine($"{this.GetType().Name} 设置滚动条");
        }

        public void CloseWindow()
        {
            Console.WriteLine($"{this.GetType().Name} 关闭窗口(单独方法)");
        }
    }
}
