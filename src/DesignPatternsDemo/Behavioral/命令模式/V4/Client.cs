using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V4
{
    public class Client
    {
        private List<AbstractCommand> _comandList = new List<AbstractCommand>();

        public void SetCommand(AbstractCommand command)
        {
            _comandList.Add(command);
        }

        public void Call()
        {
            Console.WriteLine($"{nameof(Client)} call...");
            foreach (var command in _comandList)
            {
                command.Execute();
            }
        }
    }
}
