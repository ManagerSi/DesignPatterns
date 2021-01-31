using DesignPatternsDemo.Behavioral.命令模式.V2.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V2.Commands
{
    public class HelperCommand : Command
    {
        private HelpHandler _handler;
        public HelperCommand()
        {
            _handler = new HelpHandler();
        }

        public override void Excute()
        {
            Console.WriteLine($"{nameof(HelperCommand)} Excute!");
            _handler.DisplayDocument();
        }
    }
}
