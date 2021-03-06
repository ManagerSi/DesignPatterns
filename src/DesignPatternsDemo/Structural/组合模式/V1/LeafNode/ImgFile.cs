﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.V1.LeafNode
{
    /// <summary>
    /// 叶子节点
    /// 只有KillVirus 可用，其他add/delete等均不可用，所以称为叶子节点
    /// </summary>
    public class ImgFile : AbstractFile
    {
        private readonly string _name;
        public ImgFile(string name)
        {
            _name = name;
        }
        public override void Add(AbstractFile file)
        {
            throw new NotImplementedException();
        }

        public override void Delete(AbstractFile file)
        {
            throw new NotImplementedException();
        }

        public override AbstractFile GetFile(int index)
        {
            throw new NotImplementedException();
        }

        public override void KillVirus()
        {
            Console.WriteLine($"****图像文件[{_name}]进行杀毒");
        }
    }
}
