using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.简单工厂模式.V1
{
    public class SimpleProductFactory
    {
        public static Product GetProduct(string prodType)
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
