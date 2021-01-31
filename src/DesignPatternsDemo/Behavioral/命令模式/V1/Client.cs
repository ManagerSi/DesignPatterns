using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V1
{
    /// <summary>
    /// 基础架构
    /// 请求方，无需知道被调用方（receiver)，通过command解耦
    /// </summary>
    class Client
    {
        private Command _command;
        public Client(Command command)
        {
            _command = command;
        }

        public void Call()
        {
            Console.WriteLine($"{this.GetType().Name} call...");
            _command.Execute();
        }
    }
}
