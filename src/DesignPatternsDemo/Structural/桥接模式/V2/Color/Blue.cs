using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V2.Color
{
    public class Blue : IColor
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Set color:{this.GetType().Name}");

        }
        public void Dispose()
        {
            Console.WriteLine(Console.ForegroundColor);
            Console.ResetColor();
            Console.WriteLine(Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
