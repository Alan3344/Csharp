using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 事件, event 事件与委托,是一种回调机制的设计, 委托的本质就是回调函数
namespace Delegate
{
    class Callback
    {
    }

    class ColorBox // 模拟颜色选择框
    {
        private string[] options = { "white", "black", "blue", "green" };
        public delegate void ChangeHandler(string color); // 定义委托类型

        public event ChangeHandler handler; // 定义回调 (事件处理器的集合)

        public static void onColorChanged(string color)
        {
            Console.WriteLine("使用颜色: " + color);
        }

        // 模拟用户选择
        public void UserSelectColor(int index)
        {
            string color = options[index];
            if (handler != null) handler(color); //  handler.Invoke(color)
            Console.WriteLine("选择的颜色: " + color);
        }

    }
}
