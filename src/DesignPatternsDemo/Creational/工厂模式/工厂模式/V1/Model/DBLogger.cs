using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.工厂模式.V1
{
    public class DBLogger : ILogger
    {
        public DBLogger()
        {
            Console.WriteLine($"{nameof(DBLogger)} Created");
        }
        public void WriteLog()
        {
            Console.WriteLine($"{nameof(DBLogger)} Write Log");
        }
    }
}
