using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.安全组合模式
{
    /// <summary>
    /// 所谓安全，即在本抽象类中只定义所需方法
    /// </summary>
    public abstract class AbstractFile
    {
        //public virtual void Add(AbstractFile file)
        //{
        //    throw new NotImplementedException();
        //}
        //public virtual void Delete(AbstractFile file)
        //{
        //    throw new NotImplementedException();
        //}
        //public virtual AbstractFile GetFile(int index)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 杀毒
        /// </summary>
        public abstract void KillVirus();
    }
}
