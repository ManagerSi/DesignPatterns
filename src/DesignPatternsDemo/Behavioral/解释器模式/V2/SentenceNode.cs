using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{
    public class SentenceNode: AbstractNode
    {

        private AbstractNode _direction;
        private AbstractNode _action;
        private AbstractNode _distance;

        public SentenceNode(AbstractNode direction, AbstractNode action, AbstractNode distance)
        {
            _direction = direction;
            _action = action;
            _distance = distance;
        }

        public override string Interpret()
        {
            return _direction.Interpret() + _action.Interpret() + _distance.Interpret();
        }
    }
}
