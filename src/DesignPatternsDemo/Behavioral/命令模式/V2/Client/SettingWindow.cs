using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral.命令模式.V2.Client
{
    public class SettingWindow
    {
        private List<FunctionButton> functionButtons = new List<FunctionButton>();

        public void AddButton(FunctionButton functionButton)
        {
            this.functionButtons.Add(functionButton);
        }

        public void RemoveButton(FunctionButton button)
        {
            this.functionButtons.Remove(button);
        }

        public void Display()
        {
            Console.WriteLine("窗口功能列表:");
            foreach (var item in functionButtons)
            {
                Console.WriteLine($"{item.Name}"); 
            }
        }

    }
}
