using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V2
{
    /// <summary>
    /// 坐标类，棋子的外部状态
    /// </summary>
    public class Coordinates
    {
        public int x { get; set; }
        public int y;

        public Coordinates(int x,int y)
        {
            this.x = x;
            this.y = y;
        }


    }
}
