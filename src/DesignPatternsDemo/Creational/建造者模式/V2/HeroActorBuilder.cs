using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V2
{
    public class HeroActorBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            base.BuildType();
            this.actor.Type = "英雄";
        }

        public override void BuildName()
        {
            base.BuildName();
            this.actor.Name = "Hero";
        }

        public override void BuildFace()
        {
            base.BuildFace();
            this.actor.Face = "英俊";
        }

        public override void BuildSex()
        {
            base.BuildSex();
            this.actor.Sex = "男";
        }

        public override void BuildCostume()
        {
            base.BuildCostume();
            this.actor.Costume = "风衣";
        }

        public override void BuildHairStyle()
        {
            base.BuildHairStyle();
            this.actor.HairStyle = "毛寸";
        }
    }
}
