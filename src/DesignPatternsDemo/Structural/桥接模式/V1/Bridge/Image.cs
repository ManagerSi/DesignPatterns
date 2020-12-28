using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Structural.桥接模式.V1.PlatformInterface;

namespace DesignPatternsDemo.Structural.桥接模式.V1.Bridge
{
    /// <summary>
    /// 此类作为抽象的 “桥接”类（bridge）
    /// 1. 本身由继承者实现多态
    /// 2. 包含外部方法IImageImp，其自身实现多态
    ///
    /// 这样可以通过 bridge本身的一个子类，加上包含的一个接口，可以实现动态组合
    /// </summary>
    public abstract class Image
    {
        /// <summary>
        /// 操作系统显示图像接口
        /// </summary>
        protected IPlantformImageImp _platformImp;

        public void SetImageImp(IPlantformImageImp imp)
        {
            _platformImp = imp;
        }

        public abstract void ParseFile(string imgPath);
    }
}
