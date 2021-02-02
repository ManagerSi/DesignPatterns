using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V4
{
    public class Handler3
    {
        public void DoSomething()
        {
            Console.WriteLine($"{this.GetType().Name} DoSomething!");
        }
    }
}
