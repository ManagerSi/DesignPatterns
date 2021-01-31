using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V3
{
    public class CalculatorForm
    {
        AbstractCommand _command;
        public void SetCommnad(AbstractCommand command)
        {
            _command = command;
        }
        public void Compute(int val)
        {
            _command.Execute(val);
        }
        public void Undo()
        {
            _command.Undo();
        }
        public void Redo()
        {
            _command.Redo();
        }
    }
}
