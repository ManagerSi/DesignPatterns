using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.桥接模式.V1.Bridge
{
    public class PNGImage:Image
    {
        public override void ParseFile(string imgPath)
        {
            Console.WriteLine($"从输入路径获取图像,path{imgPath}");
            Console.WriteLine($"转换为矩阵图像Matrix");
            ImageMatrix m = new ImageMatrix();
            _platformImp.DoPaint(m);
        }
    }
}
