using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V2
{
    public class DevilActorBuilder: ActorBuilder
    {
        public override void BuildType()
        {
            base.BuildType();
            this.actor.Type = "恶魔";
        }

        public override void BuildName()
        {
            base.BuildName();
            this.actor.Name = "devil";
        }

        public override void BuildFace()
        {
            base.BuildFace();
            this.actor.Face = "丑陋";
        }

        public override void BuildSex()
        {
            base.BuildSex();
            this.actor.Sex = "男";
        }

        public override void BuildCostume()
        {
            base.BuildCostume();
            this.actor.Costume = "黑皮裤";
        }

        public override void BuildHairStyle()
        {
            base.BuildHairStyle();
            this.actor.HairStyle = "光头";
        }

        public override bool IsBareHeaded()
        {
            return true;
        }
    }
}
