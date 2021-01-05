using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V1
{
    public class FlyweightFactory
    {
        ConcurrentDictionary<string, Flyweight> dic = new ConcurrentDictionary<string, Flyweight>();
        //correctDictionary<string, Flyweight> dic = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            if (dic.ContainsKey(key))
                return dic[key];

            var fly = new ConcreteFlyweight(key);
            dic.TryAdd(key, fly);
            return fly;
        }
    }
}
