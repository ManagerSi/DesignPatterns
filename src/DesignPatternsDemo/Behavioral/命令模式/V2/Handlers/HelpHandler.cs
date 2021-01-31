using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V2.Handlers
{
    public class HelpHandler
    {
        public void DisplayDocument()
        {
            Console.WriteLine($"{nameof(HelpHandler)} display document!");
        }
    }
}
