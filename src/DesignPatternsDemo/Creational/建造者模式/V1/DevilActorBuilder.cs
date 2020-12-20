using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational.建造者模式.V1
{
    public class DevilActorBuilder: ActorBuilder
    {
        public override void BuildType()
        {
            this.actor.Type = "恶魔";
        }

        public override void BuildName()
        {
            this.actor.Name = "devil";
        }

        public override void BuildFace()
        {
            this.actor.Face = "丑陋";
        }

        public override void BuildSex()
        {
            this.actor.Sex = "男";
        }

        public override void BuildCostume()
        {
            this.actor.Costume = "黑皮裤";
        }

        public override void BuildHairStyle()
        {
            this.actor.HairStyle = "光头";
        }
    }
}
