using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V2.Color
{
    public interface IColor:IDisposable
    {
        void SetColor();
    }
}
