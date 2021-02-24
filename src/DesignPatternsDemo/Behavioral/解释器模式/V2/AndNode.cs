using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{
    public class AndNode:AbstractNode
    {
        private AbstractNode _left;
        private AbstractNode _right;

        public AndNode(AbstractNode left, AbstractNode right)
        {
            _left = left;
            _right = right;
        }

        public override string Interpret()
        {
            return _left?.Interpret() + " 再 " + _right?.Interpret();
        }
    }
}
