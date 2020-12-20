using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V1
{
    public class HeroActorBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            this.actor.Type = "英雄";
        }

        public override void BuildName()
        {
            this.actor.Name = "Hero";
        }

        public override void BuildFace()
        {
            this.actor.Face = "英俊";
        }

        public override void BuildSex()
        {
            this.actor.Sex = "男";
        }

        public override void BuildCostume()
        {
            this.actor.Costume = "风衣";
        }

        public override void BuildHairStyle()
        {
            this.actor.HairStyle = "毛寸";
        }
    }
}
