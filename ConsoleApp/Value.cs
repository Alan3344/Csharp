using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#的变量类型
/*
 值类型 sbyte short int long bool float double char
 
 引用类型 object string ... 自定义的class

Console.WriteLine() 是静态方法
C# 里面的方法名以大写开头

 */


namespace ConsoleApp
{
    class Value
    {
        public void Add()
        {
            int a = 12;
            int b = a + 123;
            Console.WriteLine("结果为: " + b);
        }

        // 字符串的拼接 格式化
        public void StringFormat()
        {
            string a = "number: " + 30; // string 和 int 拼接
            string b = string.Format("姓名: {0}\t年龄: {1}", "XiaoLei", 1997); // 0表示第一个参数 1表示第二个参数
            Console.WriteLine(a);
            Console.WriteLine(b); // 支持格式化操作
            Console.WriteLine("{0}+{1}={2}", 1, 2, 1 + 2);
        }
    }
}

