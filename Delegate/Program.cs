using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate del = new Delegate(); // 一个委托对象就是一个方法的实例
            DogFunc dog = new DogFunc(del.Test1); // 传参时,要指定某个对象的某个方法
            dog(18); // 想当于 del.test1(18)
            //del.test1(18);

            // 类似实现 python的 lambda表达式, 使用变量名代替函数名,然后可以调用
            // func = lambda x: print(x+3); func(6);
            DogFunc dog2 = new DogFunc(del.Test2);
            dog2(34545);
            dog2.Invoke(234); // 以上两种调用方法等效

            // 委托静态方法不需要实例化
            DogFunc dog3 = new DogFunc(Delegate.Print);
            dog3(4);

            MyTest.MyDel();


            // UserSelectColor

            ColorBox cbox = new ColorBox();

            // 注册回调
            //cbox.handler = new ColorBox.ChangeHandler(ColorBox.onColorChanged);
            cbox.handler += new ColorBox.ChangeHandler(ColorBox.onColorChanged); // 加了event关键字需使用 += 或者 -=

            // 用户点击
            cbox.UserSelectColor(0);

            //namespace 的命名可以加点号, 例如 namespace My.School { class Classname}
            // namespace 和文件名,目录层次无关 C#里不要求文件名和类名,目录有对应关系
            // using 别名 = 包名
        }
    }
}
