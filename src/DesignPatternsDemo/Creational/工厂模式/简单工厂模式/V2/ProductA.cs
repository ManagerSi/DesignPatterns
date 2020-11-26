using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V2
{
    public class ProductA : ProductIncludeFactory
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