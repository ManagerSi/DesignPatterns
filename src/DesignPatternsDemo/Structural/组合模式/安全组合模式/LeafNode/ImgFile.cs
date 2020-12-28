using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.安全组合模式.LeafNode
{
    /// <summary>
    /// 叶子节点
    /// 只有KillVirus 可用
    /// </summary>
    public class ImgFile : AbstractFile
    {
        private readonly string _name;
        public ImgFile(string name)
        {
            _name = name;
        }

        public override void KillVirus()
        {
            Console.WriteLine($"****图像文件[{_name}]进行杀毒");
        }
    }
}
