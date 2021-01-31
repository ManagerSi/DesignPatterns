using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V3
{
    class AddCommand : AbstractCommand
    {
        private Adder _adder;
        private List<int> _values;
        private int _optionIndex;
        public AddCommand()
        {
            _adder = new Adder();
            _values = new List<int>();//操作列表，实现undo/redo
            _optionIndex = -1;
        }
        public override void Execute(int val)
        {
            //清空后面的无效值
            if (_optionIndex != _values.Count - 1)
            {
                for (int i = _values.Count-1; i > _optionIndex; i--)
                {
                    _values.RemoveAt(i);
                }
            }
            _values.Add(val);
            _optionIndex++;
            var res = _adder.Add(val);
            Console.WriteLine($"加:{val},result:{res}");
        }

        public override void Undo()
        {
            if(_optionIndex>=0)
            {
                //反向操作实现撤销
                var val = _values[_optionIndex];
                var res = _adder.Add(-val);
                Console.WriteLine($"撤销:{val},result:{res}");
                _optionIndex--;
            }
            else
            {
                Console.WriteLine($"无法撤销");
            }
        }

        public override void Redo()
        {
            if (_optionIndex < _values.Count-1)
            {
                //实现重做
                _optionIndex++;
                var val = _values[_optionIndex];
                var res = _adder.Add(val);
                Console.WriteLine($"重做:{val},result:{res}");
            }
            else
            {
                Console.WriteLine($"无法重做");
            }
        }
    }
}
