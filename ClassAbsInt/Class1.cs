using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbsInt
{
    // 抽象类不能实例化
    public abstract class Class1
    {
        public abstract void Run();
        public abstract void Fly();
    }

    public class ClassAbs : Class1
    {
        public override void Fly()
        {
            Console.WriteLine("Fly");
        }

        public override void Run()
        {
            Console.WriteLine("Run");
        }
    }

    // 接口名要求以大写的I开头
    // 多继承 一个类可以继承一个父类,和多个接口 形如: class ClassName : Parent, IA, IB, IC { }
    public interface IAudioPlayer
    {
        void Play(int[] data); // 分号结尾,没有方法体
    }

    // 接口实现
    public class XiaoMiPlayer : IAudioPlayer
    {
        public void Play(int[] data)
        {
            Console.WriteLine("da da da ...");
        }
    }

}
