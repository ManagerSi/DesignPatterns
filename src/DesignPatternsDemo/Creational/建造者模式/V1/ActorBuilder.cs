using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Creational.建造者模式.V1.Model;

namespace DesignPatternsDemo.Creational.建造者模式.V1
{
    public abstract class ActorBuilder
    {
        protected Actor actor=null;

        public void CreateActor()
        {
            actor = new Actor();
        }
        public abstract void BuildType();
        public abstract void BuildName();
        public abstract void BuildFace();
        public abstract void BuildSex();
        public abstract void BuildCostume();
        public abstract void BuildHairStyle();

        /// <summary>
        /// 省略controller，将创建流程放在一起
        /// </summary>
        /// <returns></returns>
        public Actor GetActor()
        {
            CreateActor();

            BuildType();
            BuildName();
            BuildSex();
            BuildFace();
            BuildHairStyle();
            BuildCostume();

            return actor;
        }
    }
}
