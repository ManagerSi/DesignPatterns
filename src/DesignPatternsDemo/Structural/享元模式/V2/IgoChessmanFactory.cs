using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural.享元模式.V2
{
    /// <summary>
    /// 围棋棋子类，抽象享元类
    /// </summary>
    public class IgoChessmanFactory
    {
        private static IgoChessmanFactory _factory = new IgoChessmanFactory();
        private static Dictionary<string, IgoChessman> _dic;

        private IgoChessmanFactory()
        {
            _dic = new Dictionary<string, IgoChessman>();
            _dic.Add("b", new BlackIgoChessman());
            _dic.Add("w", new WhiteIgoChessman());
        }

        public static IgoChessmanFactory GetInstance => _factory;

        public IgoChessman GetIgoChessman(string color)
        {
            if (_dic.ContainsKey(color))
                return _dic[color];
            
            return null;
        }
    }
}
