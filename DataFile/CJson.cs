using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// JToken: JObject, JArray, 
// Newtonsoft.Json 里使用了 反射技术;
// 对实体类的要求
// - 类成员所有属性可以get和set才可以
// - 所有的字段有Getter/Setter方法
// 属性和字段都可以完成反射,但属性在C#里更为常见
namespace DataFile
{
    class CJson
    {
        public static void CreatJson()
        {
            // 创建一个Json对象
            JObject json = new JObject();
            json["id"] = 202103101603;
            json["name"] = "XiaoMing";
            json.Add("sex", true);
            json.Add("phone", "13782130934");

            JArray colors = new JArray();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            json.Add("colors", colors);

            string jsonStr = json.ToString();
            Console.WriteLine(jsonStr);
            FileInfo fi = new FileInfo(json["name"] + ".json");
            FileStream fp = fi.OpenWrite();
            using (StreamWriter sw = new StreamWriter(fp))
            {
                sw.Write(jsonStr);
            }
            Console.WriteLine("json已经创建完成,位于: " + fi.FullName);
            //Console.ReadKey();

        }

        public static void ParserJson()
        {
            string jsonStr;
            FileStream fp = new FileInfo("XiaoMing.json").OpenRead();
            using (StreamReader sr = new StreamReader(fp))
            {
                jsonStr = sr.ReadToEnd();
            }
            
            JObject jo = JObject.Parse(jsonStr);
            Console.WriteLine("\nJObject.Parse:\n" + jo.ToString());
            long id = (long)jo["id"];
            string name = (string)jo["name"];
            bool sex = (bool)jo["sex"];
            long phone = (long)jo["phone"];

            Console.WriteLine("id: {0}\tname: {1}\tsex: {2}\tphone: {3}", id, name, sex ? "男" : "女", phone);

            if (jo.ContainsKey("colors"))
            {
                Console.WriteLine("存在 colors 字段");
            }
            else
            {
                Console.WriteLine("不存在 colors 字段");
            }
        }
         
    }

    // 对象的序列化: 比如 Student 类
    // C#里面吧 Student 称作实体类 (相当于Java里的POJO类)
    class Student // JsonSerial
    {
        // 属性
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }

        // Getter / Setter
        public string address;
        public string GetAddress() { return address; }
        public void SetAddress(string address) { this.address = address; }
       
    }
}
