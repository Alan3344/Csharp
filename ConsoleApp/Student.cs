using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Getter/Setter
// 一般将字段设置为private,然后分别添加 Get和Set方法

// 原则上, 一个cs文件中可以定义多个类
// class 的默认访问为internal(类似于public),可以一律设置为public

namespace ConsoleApp
{
    internal class Student // 类前不加public 默认是internal
    {
        private string name;

        // Getter
        public string GetName()
        {
            return this.name;
        }

        // Setter
        public void SetName(string name)
        {
            this.name = name;
        }
    }

    // C#的Get/Set新写法 属性
    class Student2
    {
        private string name;

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value; // value 是关键字
            }
        }

        // Get/Set 自动属性 的简写 名字以大写开头
        public int Id { get; set; }
    }

    class Person
    {
        public int id;
        public string name;
        public bool sex;
        public string phone;
        public void OutPersonInfo()
        {
            Console.WriteLine("id: {0}\t姓名: {1}\tsex: {2}\tphone: {3}", id, name, sex ? '男' : '女', phone);
        }
        public Person()
        {
            // 构造函数语法同C++
        }
        public Person(int id, bool sex)
        {
            this.id = id;
            this.sex = sex;
        }

        public override string ToString()
        {
            // 重写这个方法实现对象转为String
            // 调试的时候方便查看
            // 字符串拼接的时候方便
            Console.Write("override ToString: ");
            return string.Format("id: {0}\t姓名: {1}\tsex: {2}\tphone: {3}", id, name, sex ? '男' : '女', phone);
        }
    }
}
