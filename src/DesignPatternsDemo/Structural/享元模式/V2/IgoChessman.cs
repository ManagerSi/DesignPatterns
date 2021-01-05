using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V2
{
    /// <summary>
    /// 围棋棋子类，抽象享元类
    /// </summary>
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coordinates)
        {
            Console.WriteLine($"棋子颜色: {this.GetColor()}, 坐标: X:{coordinates.x}, Y:{coordinates.y}");
        }
    }
}
