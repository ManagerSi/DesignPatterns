using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V4
{
    public class Handler2Command : AbstractCommand
    {
        private Handler2 _handler;

        public Handler2Command()
        {
            _handler=new Handler2();
        }
        public override void Execute()
        {
            Console.WriteLine($"{this.GetType().Name} Execute!");
            _handler.DoSomething();
        }
    }
}
