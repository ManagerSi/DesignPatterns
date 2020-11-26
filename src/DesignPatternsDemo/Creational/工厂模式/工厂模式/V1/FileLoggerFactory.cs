using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.工厂模式.V1
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger()
        {
            Console.WriteLine("Create [Default] Share Folder");
            return new FileLogger();
        }

        public ILogger GetLogger(string input)
        {
            Console.WriteLine($"Create {input} Share Folder");
            return new FileLogger();
        }
    }
}
