using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V2
{
    public class AngelActorBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            base.BuildType();
            this.actor.Type = "天使";
        }

        public override void BuildName()
        {
            base.BuildName();
            this.actor.Name = "天使";
        }

        public override void BuildFace()
        {
            base.BuildFace();
            this.actor.Face = "漂亮";
        }

        public override void BuildSex()
        {
            base.BuildSex();
            this.actor.Sex = "女";
        }

        public override void BuildCostume()
        {
            base.BuildCostume();
            this.actor.Costume = "白裙";
        }

        public override void BuildHairStyle()
        {
            base.BuildHairStyle();
            this.actor.HairStyle = "长发";
        }
    }
}
