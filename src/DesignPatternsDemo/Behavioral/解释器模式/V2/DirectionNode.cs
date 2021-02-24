using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{
    public class DirectionNode:AbstractNode
    {
        private string _direction;

        public DirectionNode(string direction)
        {
            _direction = direction;
        }
        public override string Interpret()
        {
            switch (_direction)
            {
                case "up":
                    return "向上";
                case "down":
                    return "向下";
                case "left":
                    return "向左";
                case "right":
                    return "向右";
                default:
                    return "方向未知";
            }
        }
    }
}
