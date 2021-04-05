using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#里面的方法名要求大写
// 垃圾自动回收 GC, 只管创建(new),不用管销毁,失去引用的对象由GC 自动回收
namespace ConsoleApp
{
    // 类的拆分, 类名一样 类的分开定义,不影响互相调用,在WinForm里面使用的多
    public partial class Example
    {
        int num;
        void GetNum()
        {
            Console.WriteLine(num);
        }
    }
}
