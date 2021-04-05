using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 委托, delegate, 是C#中一种回调的实现, 是一个对方法类型的描述
 * C语言里的函数指针
 * C++/Qt里的信号和槽
 * Java里面的接口/监听器
 * 
 * public void test1() { } 参数类型列表, 函数的返回值
 * 
 * 委托是一种类型,可以和class, interface 同级定义, 也可以作为内部类型
 * 
 */
namespace Delegate
{
    // 三类方法
    public delegate void DogFunc(int a);
    public delegate int CatFunc(int b);
    public delegate int FishFunc(int a, int b);

    public class Delegate
    {
        public void Test1(int a)
        {
            Console.WriteLine("a: " + a);
        }
        public void Test2(int b)
        {
            Console.WriteLine("b: " + b);
        }
        public static void Print(int c)
        {
            Console.WriteLine(c * 3);
        }

        public delegate void DelTest3(int x);

    }

    class MyTest
    {
        public static void MyDel()
        {
            // 类中使用委托类型
            DogFunc dog = new DogFunc(Delegate.Print);
            dog(123);
        }
    }
}
