using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V2
{
    public class ProductB : ProductIncludeFactory
    {
        public ProductB()
        {
            Console.WriteLine($"{nameof(ProductB)} Create");
        }
        public override void Show()
        {
            Console.WriteLine($"{nameof(ProductB)} Show");
        }
    }
}