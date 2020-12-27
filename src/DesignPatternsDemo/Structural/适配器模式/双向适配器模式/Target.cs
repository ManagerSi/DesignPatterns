using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.双向适配器模式
{
    public class Target
    {
        public void DoSomething() 
        {
            Console.WriteLine($"{typeof(Target)} 的特殊方法1");
        }
        public void DoSomething2()
        {
            Console.WriteLine($"{typeof(Target)} 的特殊方法2");
        }
    }
}
