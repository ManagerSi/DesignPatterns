using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.原型模式.V1.Model
{
    [Serializable]
    public class Address
    {
        public string Street { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 县
        /// </summary>
        public string county { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }

        //区(qū) : 
        public string district { get; set; }
        //大街(dàjiē): 
        public string avenue { get; set; }
        //路(lù):
        public string road { get; set; }
        //楼(lóu):
        public string building { get; set; }
        //室(shì):
        public string house { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string postcode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
    }
}
