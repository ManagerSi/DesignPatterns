using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Creational.建造者模式.V2.Model;

namespace DesignPatternsDemo.Creational.建造者模式.V2
{
    public abstract class ActorBuilder
    {
        protected Actor actor=null;

        public void CreateActor()
        {
            actor = new Actor();
        }

        public virtual void BuildType()
        {
            Console.WriteLine("Set Type");
        }
        public virtual void BuildName()
        {
            Console.WriteLine("Set Name");
        }
        public virtual void BuildFace()
        {
            Console.WriteLine("Set Face");
        }
        public virtual void BuildSex()
        {
            Console.WriteLine("Set Sex");
        }
        public virtual void BuildCostume()
        {
            Console.WriteLine("Set Costume");
        }
        public virtual void BuildHairStyle()
        {
            Console.WriteLine("Set HairStyle");
        }

        /// <summary>
        /// 钩子方法，可以控制流程
        /// 是否光头
        /// </summary>
        /// <returns></returns>
        public virtual bool IsBareHeaded()
        {
            return false;
        }

        public Actor GetActor()
        {
            return actor;
        }
    }
}
