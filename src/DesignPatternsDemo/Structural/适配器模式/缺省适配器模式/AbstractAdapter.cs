using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.适配器模式.缺省适配器模式
{
    /// <summary>
    /// target 方法较多，但并非全都需要，定义此类使用默认实现所有方法
    /// 定义adapter类继承此类，覆写需要的方法
    /// </summary>
    public class AbstractAdapter : Target
    {
        public virtual void DoSomething()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething2()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething3()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething4()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething5()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething6()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething7()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething8()
        {
            throw new NotImplementedException();
        }

        public virtual void DoSomething9()
        {
            throw new NotImplementedException();
        }
    }
}
