using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V1
{
    public class AngelActorBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            this.actor.Type = "天使";
        }

        public override void BuildName()
        {
            this.actor.Name = "天使";
        }

        public override void BuildFace()
        {
            this.actor.Face = "漂亮";
        }

        public override void BuildSex()
        {
            this.actor.Sex = "女";
        }

        public override void BuildCostume()
        {
            this.actor.Costume = "白裙";
        }

        public override void BuildHairStyle()
        {
            this.actor.HairStyle = "长发";
        }
    }
}
