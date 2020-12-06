using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1.Model;

namespace DesignPatternsDemo.Creational.工厂模式.抽象工厂模式.V1
{
    public class SpringSkinFactory:ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public IComboBox CreateComboBox()
        {return new SpringComboBox();}

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}
