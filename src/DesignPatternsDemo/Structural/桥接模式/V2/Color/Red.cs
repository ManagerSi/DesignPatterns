using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V2.Color
{
    public class Red : IColor
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Set color:{this.GetType().Name}");

        }

        public void Dispose()
        {
            Console.WriteLine("-----------Dispose-------------");
            Console.WriteLine(Console.ForegroundColor);
            Console.ResetColor();
            Console.WriteLine(Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
