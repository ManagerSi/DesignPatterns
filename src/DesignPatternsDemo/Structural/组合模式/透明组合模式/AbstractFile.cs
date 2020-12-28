using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.透明组合模式
{
    /// <summary>
    /// 所谓透明，即在本抽象类中直接将全部方法定义好，leaf节点无需做更多操作
    /// 
    /// </summary>
    public abstract class AbstractFile
    {
        public virtual void Add(AbstractFile file)
        {
            throw new NotImplementedException();
        }
        public virtual void Delete(AbstractFile file)
        {
            throw new NotImplementedException();
        }
        public virtual AbstractFile GetFile(int index)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 杀毒
        /// </summary>
        public abstract void KillVirus();
    }
}
