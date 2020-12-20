using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V2.Model
{
    /// <summary>
    /// 游戏角色
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 脸型
        /// </summary>
        public string Face { get; set; }
        /// <summary>
        /// 服装
        /// </summary>
        public string Costume { get; set; }
        /// <summary>
        /// 发型
        /// </summary>
        public string  HairStyle { get; set; }

        public void Show()
        {
            Console.WriteLine($"角色类型:{Type},名称:{Name},性别:{Sex},脸型:{Face},服装:{Costume},发型:{HairStyle}");
        }
    }
}
