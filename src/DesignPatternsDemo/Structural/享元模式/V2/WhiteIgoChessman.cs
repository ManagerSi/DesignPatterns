using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V2
{
    public class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}
