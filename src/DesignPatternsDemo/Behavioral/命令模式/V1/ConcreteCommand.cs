using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V1
{
    public class ConcreteCommand : Command
    {
        private Receiver _receiver = new Receiver();
        public override void Execute()
        {
            Console.WriteLine($"{this.GetType().Name} execute!");
            _receiver.Play();
        }
    }
}
