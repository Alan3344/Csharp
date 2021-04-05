using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 类的继承
/*
 * public/protected 可以继承
 * 单根继承,只有一个父类,如果未指定父类,则父类为object
 * 
 * 在Java/C#中,多态是指
 * 1. 方法名的重载 Overload
 * 2. 继承时的方法重写 Override
 * 3. 泛型 Generic Type
 */
namespace ConsoleApp
{
    class Parent // 父类
    {
        public int number;
        public void Output()
        {
            Console.WriteLine("number: " + number);
        }

        // 如果子类要重写父类的方法, 父类需声明加上 virtual, 子类声明加上 override
        public virtual void Translate()
        {
            // 父类定义虚方法
            Console.WriteLine("父类 number: " + number);
        }
    }

    class MyParent : Parent
    {
        public void MyOuput()
        {
            this.number = 123;
        }

        public override void Translate()
        {
            //base.Translate();  // 子类调用父类方法 用base Java用super
            Console.WriteLine("子类调用 数字: " + number);
        }
    }

    // 构造方法的继承
    public class Point : object
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Point3D : Point
    {
        public int z;
        public Point3D(int x, int y, int z):base(x, y)
        {
            this.z = z;
        }
    }

}