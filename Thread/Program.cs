using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

// 构造Thread对象时,传一个委托,static方法和实例方法均可
// 主线程退出时,进程并没有立即退出(前台线程,后台线程)
// 当所有的前台线程都结束时,整个进程退出,如果此时有后台线程还在运行,则强行终止
namespace MyThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ////MyCounter counter = new MyCounter();
            ////counter.Run();

            //MyCounter counter = new MyCounter();
            //Thread t1 = new Thread(new ThreadStart(counter.Run));
            //t1.IsBackground = true; // true 前台线程 false 后台线程
            //t1.Start();
            ////t1.Join(); // 等待目标线程退出 (阻塞等待)
            //Console.WriteLine("主线程退出...");
            ////MessageBox.Show("主线程退出...");
            ////GC.Collect();

            //ThreadPool.QueueUserWorkItem(new WaitCallback(MyThread.Pool.SimpleJob));
            //Console.ReadLine(); // QueueUserWorkItem都是后台线程, 当进程退出时,会导致正在执行的任务(线程)被中断
            //Console.WriteLine("Main退出");

            MyTimer.My_Timer();
            Console.ReadLine();
            Console.WriteLine("Main退出");
        }
    }
}

// GC.Collect() // 垃圾回收,如果句柄无限增长
// GC是一个自动的过程,一般不要干预,频繁干预会导致性能下降

// 线程池如果空闲,则会取出线程来执行这个任务,线程池如果忙碌,则会排到队列等待执行
// ThreadPool.SetMaxThreads() 可以设置最大容量

/*
 * ThreadPool 和 Thread对比:
 *  ThreadPoo: 适合较短小的任务  /  后台线程        / 自动管理,无法控制
 *  Thread: 任务长任务           / 默认为前台线程   / 手动管理, 可以灵活控制
 * 
*/