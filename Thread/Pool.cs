using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThread
{
    class Pool
    {
        public static void SimpleJob(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("任务 " + (i+1));
                Thread.Sleep(1000);
            }
            Console.WriteLine("任务完毕");
        }
    }

    // 一共4个Timer类
    // 创建一个定时器 new Timer(callback:委托任务, state:任务参数, dueTime: 定时器第一次执行时间, period: 周期执行间隔时间)
    //                                                           0, 立即开始执行               0, 禁用
    //                                                           n, n毫秒之后执行              n, n毫秒之后执行
    //                                                           Timeout.Infinite 禁用        Timeout.Infinite 禁用
    //                                                          如果小鱼系统时间紧固带,则无意义(15ms左右)   
    class MyTimer
    {
        public static void My_Timer()
        {
            Timer timer = new Timer(new TimerCallback(Pool.SimpleJob), null, 1000, 2000);
        }
    }
}
