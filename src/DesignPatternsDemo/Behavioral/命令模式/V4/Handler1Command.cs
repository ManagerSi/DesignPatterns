using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V4
{
    public class Handler1Command:AbstractCommand
    {
        private Handler1 _handler;

        public Handler1Command()
        {
            _handler=new Handler1();
        }
        public override void Execute()
        {
            Console.WriteLine($"{this.GetType().Name} Execute!");
            _handler.DoSomething();
        }
    }
}
