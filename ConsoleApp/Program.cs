using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Args: " + args);

            Student stu = new Student();
            stu.SetName("Li Jun");
            Console.WriteLine("Student姓名: " + stu.GetName());

            // 第二种调用
            //Student2 stu2 = new Student2();
            //stu2.Name = "Shao Fa";
            //Console.WriteLine("Student2姓名: " + stu2.Name);

            // 第二种写法
            Student2 stu2 = new Student2
            {
                Name = "Shao Fa"
            };

            Console.WriteLine("Student2 姓名: " + stu2.Name);
            stu2.Id = 10;
            Console.WriteLine("Student2 Id: " + stu2.Id);

            // 值
            Value value = new Value();
            value.Add();
            value.StringFormat();

            Person person = new Person();
            person.id = 20210308;
            person.name = "XiaoHong";
            person.sex = false;
            person.phone = "16834643123";
            person.OutPersonInfo();
            Console.WriteLine(person.ToString());

            Parent pIn = new MyParent();
            pIn.number = 234;
            pIn.Translate();

        }
    }
}
