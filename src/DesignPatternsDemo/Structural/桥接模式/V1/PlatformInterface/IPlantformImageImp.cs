using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V1.PlatformInterface
{
    /// <summary>
    /// 操作系统绘制图像接口
    /// </summary>
    public interface IPlantformImageImp
    {
        void DoPaint(ImageMatrix m);
    }
}
