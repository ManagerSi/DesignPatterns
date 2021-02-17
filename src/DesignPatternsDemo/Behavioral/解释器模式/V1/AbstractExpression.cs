using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.解释器模式.V1
{
    public abstract class AbstractExpression
    {
        public abstract void Interpreter(ExpressionContext context);
    }
}
