using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V1.PlatformInterface
{
    public class MacOSImp : IPlantformImageImp
    {
        public void DoPaint(ImageMatrix m)
        {
            Console.WriteLine($"在{this.GetType().Name}显示图像");
        }
    }
}
