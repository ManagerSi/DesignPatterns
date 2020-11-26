﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.工厂模式.工厂模式.V1
{
    public interface ILoggerFactory
    {
        ILogger GetLogger();
        ILogger GetLogger(string input);
    }
}
