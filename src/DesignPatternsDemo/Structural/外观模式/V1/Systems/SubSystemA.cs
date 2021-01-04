using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.外观模式.V1.Systems
{
    public class ServiceA
    {
        public void Method()
        {
            Console.WriteLine($"{this.GetType().Name} invoke method");
        }
    }
}
