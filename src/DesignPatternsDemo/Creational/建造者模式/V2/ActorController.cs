using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsDemo.Creational.建造者模式.V2.Model;

namespace DesignPatternsDemo.Creational.建造者模式.V2
{
    /// <summary>
    /// 实现对构建过程的控制，客户实际使用此类构建actor
    /// </summary>
    public class ActorController
    {
        private ActorBuilder _actorBuilder;

        public ActorController(ActorBuilder ab)
        {
            _actorBuilder = ab;
        }

        /// <summary>
        /// 通过builder构建并返回actor
        /// </summary>
        /// <returns></returns>
        public Actor ConstructActor()
        {
            _actorBuilder.CreateActor();

            _actorBuilder.BuildType();
            _actorBuilder.BuildName();
            _actorBuilder.BuildSex();
            _actorBuilder.BuildFace();

            //控制流程
            if(!_actorBuilder.IsBareHeaded())
                _actorBuilder.BuildHairStyle();

            _actorBuilder.BuildCostume();

            return _actorBuilder.GetActor();
        }
    }
}
