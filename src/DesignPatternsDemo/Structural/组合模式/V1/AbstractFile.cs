using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.V1
{
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile file);
        public abstract void Delete(AbstractFile file);
        public abstract AbstractFile GetFile(int index);
        /// <summary>
        /// 杀毒
        /// </summary>
        public abstract void KillVirus();
    }
}
