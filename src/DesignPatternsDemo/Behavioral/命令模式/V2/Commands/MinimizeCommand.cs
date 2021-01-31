using DesignPatternsDemo.Behavioral.命令模式.V2.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V2.Commands
{
    class MinimizeCommand : Command
    {
        private WindowHandler _handler;
        public MinimizeCommand()
        {
            _handler = new WindowHandler();
        }
        public override void Excute()
        {
            Console.WriteLine($"{nameof(MinimizeCommand)} Excute!");
            _handler.Minimize();
        }
    }
}
