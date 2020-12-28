using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V2.Pen
{
    public class ThinPen :AbstractPen
    {
        public ThinPen()
        {
            //could not change the console font weight....
            _penWeight = 50;
            Console.WriteLine($"Change pen weight: {_penWeight}");
        }
        public override void Draw()
        {
            _color.SetColor();
            Console.WriteLine($"{this.GetType().Name} Draw with color");
        }
    }
}
