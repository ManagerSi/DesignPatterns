using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V1
{
    public class NonterminalExpression : AbstractExpression
    {
        private string _Expression = null;
        public NonterminalExpression(string expression)
        {
            _Expression = expression;
        }

        public override void Interpreter(ExpressionContext context)
        {
            if (_Expression != null)
            {
                var commandList = _Expression.ToLower().Split("and");
                foreach (var commandStr in commandList)
                {
                    var args = commandStr.Trim().Split(' ');
                    var terminalExpression = new  TerminalExpression(args[0], args[2], args[1]);
                    terminalExpression.Interpreter(context);
                }
            }
        }
    }
}
