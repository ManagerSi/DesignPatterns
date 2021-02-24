using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V2
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class InstructionHandler
    {
        private AbstractNode _node;

        public void Handle(string instruction)
        {
            AbstractNode left, right;
            AbstractNode direction, action, distance;
            Stack<AbstractNode> stack = new Stack<AbstractNode>();
            string[] words = instruction.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "and")
                {
                    var w1 = words[i];
                    var w2 = words[++i];
                    var w3 = words[++i];

                    direction = new DirectionNode(w1);
                    action = new ActionNode(w2);
                    distance = new DistanceNode(w3);

                    left = new SentenceNode(direction, action, distance);
                    stack.Push(left);
                }
                else
                {

                    var w1 = words[++i];
                    var w2 = words[++i];
                    var w3 = words[++i];

                    direction = new DirectionNode(w1);
                    action = new ActionNode(w2);
                    distance = new DistanceNode(w3);

                    right = new SentenceNode(direction, action, distance);
                    left = stack.Pop();
                    var andNode = new AndNode(left, right);
                    stack.Push(andNode);
                }
            }

            _node = stack.Pop();
        }

        public string Output()
        {
            return _node?.Interpret();
        }
    }
}
