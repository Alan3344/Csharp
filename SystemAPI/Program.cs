using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string str in args)
            {
                Console.WriteLine(str);
            }
            
            Random rd = new Random();
            int rd_int = rd.Next(10);
            Console.WriteLine("随机数: " + rd_int);

            // 异常
            try
            {
                int a = Convert.ToInt32("123a5");
                Console.WriteLine("结果:" + a);
            }catch (Exception e)
            {
                Console.WriteLine("出错: " + e.Message);
                //Console.WriteLine("StackTrace: " + e.StackTrace); // 打印堆栈信息
            }

            if (true)
            {
                //throw new NotFoundException("");
            }

            FileInfo fi = new FileInfo(@"C:\Users\Xander\source\repos\CSharp\ConsoleApp\SystemAPI\123.dat");
            using (FileStream stream = fi.OpenWrite())
            {
                byte[] data = { 1, 2, 3, 4, 0xa0, 0xb1, 0xc2, 0xc3 };
                stream.Write(data, 0, data.Length);
            }
            Console.ReadKey();

        }
    }
}
