using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThread
{
    class MyCounter
    {
        public void Run()
        {
            Thread tid = Thread.CurrentThread;
            Console.WriteLine("当前线程id: " + tid.ManagedThreadId);
            int i = 10;
            while (i>0)
            {
                Console.Write(i + " ");
                i -= 1;
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n倒计时线程退出...");
        }
    }

    // 当多个线程访问同一个资源时,需要实现互斥访问
    // 1. 使用lock语法(对应Java的syncchronized)    lock(lockResource) { Access to the Resource }
    // 2. 使用Mutex/Semaphore
    class MyFactory
    {
        private readonly object resourceLock = new object(); // 资源锁
        List<int> repo =  new List<int>();

        // 向repo中添加产品
        public void Produce()
        {
            Random rand = new Random();
            while(true)
            {
                lock (resourceLock) // 一个资源一把锁 resourceLock用repo 也可以
                {
                    int number = rand.Next(10000);
                    repo.Add(number);
                    Console.WriteLine("添加:" + number);
                    Thread.Sleep(1000);
                }
            }
        }
        public void Consume()
        {
            Random rand = new Random();
            while(true)
            {
               lock(resourceLock) // 加上访问权限
                {
                    if (repo.Count > 0)
                    {
                        int number = repo[0];
                        repo.RemoveAt(0);
                        Console.WriteLine("取走: " + number);
                    }
                }
            }
        }
    }
}
