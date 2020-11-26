using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.工厂模式.V1
{
    public class FileLogger : ILogger
    {
        public FileLogger()
        {
            Console.WriteLine($"{nameof(FileLogger)} Created");
        }
        public void WriteLog()
        {
            Console.WriteLine($"{nameof(FileLogger)} Write Log");
        }
    }
}
