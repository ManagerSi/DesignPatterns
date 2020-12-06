using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1.Model
{
    public class SpringTextField:ITextField 
    {
        public void Display()
        {
            Console.WriteLine($"{this.GetType().Name} display");
        }
    }
}
