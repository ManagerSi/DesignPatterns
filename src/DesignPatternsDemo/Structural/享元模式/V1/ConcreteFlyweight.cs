using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V1
{
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public override void ShowState(string extrinsicState)
        {
            Console.WriteLine($"{this.GetType().Name} show states, intrinsicState:{_intrinsicState}, extrinsicState:{extrinsicState}");
        }
    }
}
