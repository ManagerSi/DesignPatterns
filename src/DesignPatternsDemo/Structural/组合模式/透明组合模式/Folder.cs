using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.透明组合模式
{
    /// <summary>
    /// 组合类
    /// </summary>
    public class Folder : AbstractFile
    {
        private List<AbstractFile> _files = new List<AbstractFile>();
        private readonly string _name;
        public Folder(string name)
        {
            _name = name;
        }
        public override void Add(AbstractFile file)
        {
            _files.Add(file);
        }

        public override void Delete(AbstractFile file)
        {
            _files.Remove(file);
        }

        public override AbstractFile GetFile(int index)
        {
            if (index < 0 || index >= _files.Count) return null;

            return _files[index];
        }

        public override void KillVirus()
        {
            Console.WriteLine($"--文件夹[{_name}]进行杀毒");
            foreach (var item in _files)
            {
                item.KillVirus();
            }
            Console.WriteLine($"--文件夹[{_name}]完成杀毒");
        }
    }
}
