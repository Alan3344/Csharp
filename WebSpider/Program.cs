using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebSpider
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.baidu.com/";

            //string res = Baidu.SendHttPost(url, "");
            //Console.WriteLine(res);

            string res = Baidu.Get(url);
            Console.WriteLine(res);
            
            FileInfo fi = new FileInfo("baidu.html");

            byte[] data = Encoding.UTF8.GetBytes(res);
            using(FileStream sr = fi.OpenWrite())
            {
                sr.Write(data, 0, data.Length);
            }
        }
    }
}
