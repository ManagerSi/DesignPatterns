using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V1
{
    public abstract class Flyweight
    {
        /// <summary>
        /// 内部状态
        /// </summary>
        internal string _intrinsicState;

        /// <summary>
        /// 显示状态
        /// </summary>
        /// <param name="extrinsicState">外部状态</param>
        public abstract void ShowState(string extrinsicState);
    }
}
