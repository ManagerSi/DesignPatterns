using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.工厂模式.V1
{
    public class DBLoggerFactory:ILoggerFactory
    {
        public ILogger GetLogger()
        {
            Console.WriteLine("Connect Default DB");
            return new DBLogger();
        }

        public ILogger GetLogger(string input)
        {
            Console.WriteLine($"Connect {input} DB");
            return new DBLogger();
        }
    }
}
