using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V3
{
    public abstract class AbstractCommand
    {
        public abstract void Execute(int val);
        public abstract void Undo();
        public abstract void Redo();
    }
}
