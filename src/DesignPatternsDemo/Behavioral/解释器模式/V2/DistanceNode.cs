using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{
    class DistanceNode:AbstractNode
    {
        private string _distance;

        public DistanceNode(string distance)
        {
            _distance = distance;
        }
        public override string Interpret()
        {
            return _distance;
        }
    }
}
