using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V1
{
    /// <summary>
    /// 命令接收方
    /// </summary>
    public class Receiver
    {
        public void Play()
        {
            Console.WriteLine($"{nameof(Receiver)} Play.");
        }
    }
}
