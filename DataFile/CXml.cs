using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

/*
 * XmlDocument
 * XmlDeclaration
 * XmlElement
 */
namespace DataFile
{
    class CXml
    {
        public string filename = "student.xml";

        public static void CreatXml()
        {
            XmlDocument doc = new XmlDocument(); // 创建一个xml文档对象
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null); // 创建xml文档的头声明

            doc.AppendChild(dec);
            // root 根节点
            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            // <root>/<student>
            XmlElement student = doc.CreateElement("student");
            root.AppendChild(student);

            // 节点属性
            student.SetAttribute("type", "long");
            student.SetAttribute("id", "202103100049");

            // <root>/<student>/<name>
            XmlElement name = doc.CreateElement("name");
            name.InnerText = "小芳";
            name.SetAttribute("type", "string");
            student.AppendChild(name);

            XmlElement age = doc.CreateElement("age");
            age.InnerText = "23";
            age.SetAttribute("type", "int");
            student.AppendChild(age);

            doc.Save("student.xml");
            Console.WriteLine("doc.Save Ok");
            // & < > 等字符会被转义,同HTML实体
        }


        /*
         * 1. 加载: doc.Load() doc.LoadXml(), 注意studentl.xml的位置
         * 2. 取得目标节点 根节点: doc.DocumentElement, 指定路径: SelectSingleNode(path), SelectNodes(path)
         * 3. 获取子节点的值 string x = node["x"].InnerText
         */
        public static void ParserXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("student.xml");

            XmlElement root = xml.DocumentElement; // 获取根元素
            XmlElement student = (XmlElement)root.SelectSingleNode("student"); // 按路径取出一个节点

            string name = student["name"].InnerText;
            Console.WriteLine("id: " + student.GetAttribute("id"));
            Console.WriteLine("type: " + student.GetAttribute("type"));
            Console.WriteLine(name);
            Console.WriteLine("/xpath:" + root.SelectSingleNode("student/name").InnerText);

        }
    }
}
