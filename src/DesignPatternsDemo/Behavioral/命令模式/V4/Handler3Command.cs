using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V4
{
    public class Handler3Command : AbstractCommand
    {
        private Handler3 _handler;

        public Handler3Command()
        {
            _handler=new Handler3();
        }
        public override void Execute()
        {
            Console.WriteLine($"{this.GetType().Name} Execute!");
            _handler.DoSomething();
        }
    }
}
