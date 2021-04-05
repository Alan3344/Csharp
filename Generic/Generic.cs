using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#里支持泛型语法, 例如 List<int> aaa = new List<int>() 列表类, 想当于Java的ArrayList
// Add() Inert() Remove() Count() 支持索引器访问,例如 aaa[i] = 12

// Dictionary, 字典类,相当于Java里的HashMap new Dictionary<TKey, TValue>()
// 创建字典,指定Key类型和Value类型 Add(key, value) 添加时已存在报错 Remove(key) 删除这个键
// ContainsKey(key) 判断key是否存在,返回 true/false
// dict[key] 以key为索引,设置或取值,取值时如果key不在,则抛出异常
// TryGetValue(key, out value) 尝试获取值,如果存在,则修改value值
namespace Generic
{
    class Generic
    {
        public static void MyGeneric()
        {
            List<int> aaa = new List<int>();
            aaa.Add(12);
            aaa.Add(3);
            aaa.Add(8);
            aaa.Add(29);

            // 普通遍历
            for (int i = 0; i < aaa.Count(); i++)
            {
                Console.Write(aaa[i] + " ");
            }
            Console.WriteLine();

            // foreach 遍历
            foreach(int item in aaa)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // list dictionary 都是集合类, 遍历方式(foreach 枚举遍历) 官方建议使用foreach
            // 不支持一边遍历一边删除的操作(foreach和枚举器都是只读遍历)

            // 枚举遍历
            List<int>.Enumerator en = aaa.GetEnumerator();
            while (en.MoveNext())
            {
                Console.Write(en.Current + " ");
            }
            Console.WriteLine();
        }

        public static void MyDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("name", "xiao jun");
            dict.Add("addr", "An Xi");
            dict.Add("phone", "16435345656");
            dict.Add("smallname", "xiao xiao");

            dict["other"] = "null";

            string xml;
            if (dict.ContainsKey("xml")) xml = dict["xml"];
            else xml = "null";


            
            // 尝试取值
            //string dvalue = "null";
            dict.TryGetValue("xml", out string dvalue); // dvalue 不需要定义
            Console.WriteLine("dvalue: " + dvalue);

            dict.TryGetValue("addr", out string dvalue2); // dvalue 不需要定义
            Console.WriteLine("dvalue2: " + dvalue2);

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kv in dict)
            {
                Console.WriteLine("{0}: {1}", kv.Key, kv.Value);
            }
        }
    }
}
