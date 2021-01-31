using DesignPatternsDemo.Behavioral.命令模式.V2.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V2.Client
{
    public class FunctionButton
    {
        public string Name { get; set; }
        private Command _command;
        public FunctionButton(string name)
        {
            this.Name = name;
        }
        public void SetCommand(Command command)
        {
            this._command = command;
        }
        public void Click()
        {
            Console.WriteLine($"{nameof(FunctionButton)}:{this.Name} click.");
            _command.Excute();
        }
    }
}
