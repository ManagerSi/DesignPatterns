using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Structural.外观模式.V1.Systems;

namespace DesignPatternsDemo.Structural.外观模式.V1
{
    /// <summary>
    /// 外观模式
    /// 统一所有系统方法及流程，对外提供服务
    /// </summary>
    public class Facade
    {
        private readonly ServiceA _serviceA;
        private readonly ServiceB _serviceB;
        private readonly ServiceC _serviceC;

        public Facade()
        {
            _serviceA = new ServiceA();
            _serviceB = new ServiceB();
            _serviceC = new ServiceC();
        }

        public void Method()
        {
            _serviceA.Method();
            _serviceB.Method();
            _serviceC.Method();
        }
    }
}
