using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1.Model;

namespace DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1
{
    public class SummerSkinFactory:ISkinFactory
    {
        public IButton CreateButton()
        {return new SummerButton();}

        public IComboBox CreateComboBox()
        {return new SummerComboBox();}

        public ITextField CreateTextField()
        {return new SummerTextField();
        }
    }
}
