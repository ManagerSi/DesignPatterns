using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{

    public class ActionNode : AbstractNode
    {
        private string _action;

        public ActionNode(string action)
        {
            _action = action;
        }
        public override string Interpret()
        {
            switch (_action)
            {
                case "run":
                    return "跑";
                case "walk":
                    return "走";
                default:
                    return "方式未知";
            }
        }
    }
}
