using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V1
{
    public class ProductA : Product
    {
        public ProductA()
        {
            Console.WriteLine($"{nameof(ProductA)} Create");
        }
        public override void Show()
        {
            Console.WriteLine($"{nameof(ProductA)} Show");
        }
    }
}