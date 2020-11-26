using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V2
{
    public abstract class ProductIncludeFactory
    {
        public abstract void Show();

        public static ProductIncludeFactory GetProduct(string prodType)
        {
            switch (prodType)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new EntryPointNotFoundException();
            }
        }
    }
}
