using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.透明组合模式.LeafNode
{
    public class TextFile : AbstractFile
    {
        private readonly string _name;
        public TextFile(string name)
        {
            _name = name;
        }
        public override void KillVirus()
        {
            Console.WriteLine($"****文本文件[{_name}]进行杀毒");
        }
    }
}
