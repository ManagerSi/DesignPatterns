using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V1
{
    public class TerminalExpression : AbstractExpression
    {
        private string _direction;
        private string _speed;
        private string _runWay;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="speed"></param>
        /// <param name="runWay"></param>
        public TerminalExpression(string direction, string speed, string runWay)
        {
            _direction = direction;
            _speed = speed;
            _runWay = runWay;
        }

        public override void Interpreter(ExpressionContext context)
        {
            var (d,s,r) = GetValueTuple();
            Console.WriteLine($"{d} {r} {s} m");
        }

        private (string d, string s, string r) GetValueTuple()
        {
            string d, r;
            switch (_direction)
            {
                case "up":
                    d = "向上";
                    break;
                case "down":
                    d = "向下";
                    break;
                case "left":
                    d = "向左";
                    break;
                case "rigth":
                    d = "向右";
                    break;
                default:
                    d = "方向未知";
                    break;
            }

            switch (_runWay)
            {
                case "run":
                    r = "跑";
                    break;
                case "walk":
                    r = "走";
                    break;
                default:
                    r = "方式未知";
                    break;
            }

            return (d,_speed,r);
        }
    }
}
