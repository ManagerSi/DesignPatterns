using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Structural.桥接模式.V2.Color;

namespace DesignPatternsDemo.Structural.桥接模式.V2.Pen
{
    public abstract class AbstractPen
    {
        protected IColor _color;
        protected int _penWeight = 100;
        public void SetColor(IColor color)
        {
            _color = color;
        }

        public abstract void Draw();

        ~AbstractPen()
        {
            Console.WriteLine("AbstractPen 的析构函数");
            Console.ResetColor();
            _color = null;
        }

    }
}
