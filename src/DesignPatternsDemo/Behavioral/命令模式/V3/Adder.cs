using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V3
{
    public class Adder
    {
        private int _result = 0;
        public int Add(int value)
        {
            _result += value;
            return _result;
        }
    }
}
