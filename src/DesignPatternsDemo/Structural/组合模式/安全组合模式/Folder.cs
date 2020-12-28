using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.组合模式.安全组合模式
{
    /// <summary>
    /// 组合类
    /// 所谓安全，除公共方法KillVirus外，其余方法自行定义使用
    /// </summary>
    public class Folder : AbstractFile
    {
        private List<AbstractFile> _files = new List<AbstractFile>();
        private readonly string _name;
        public Folder(string name)
        {
            _name = name;
        }

        #region MyRegion

        public void Add(AbstractFile file)
        {
            _files.Add(file);
        }

        public void Delete(AbstractFile file)
        {
            _files.Remove(file);
        }

        public AbstractFile GetFile(int index)
        {
            if (index < 0 || index >= _files.Count) return null;

            return _files[index];
        }
        #endregion

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
