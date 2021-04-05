using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CXml.CreatXml();
            //CXml.ParserXml();

            //CJson.CreatJson();
            //CJson.ParserJson();


            Student stu = new Student();
            stu.Id = 202103101651;
            stu.Name = "Tom";
            stu.Sex = true;
            stu.Phone = "13626335915";
            stu.SetAddress("地球");


            // 序列化 Serialize: Student -> Json String
            string jsonstr = JsonConvert.SerializeObject(stu);  //  Student -> Json String
            Student pojo = JsonConvert.DeserializeObject<Student>(jsonstr); // Json String -> Student
            Console.WriteLine("jsonstr: " + jsonstr);
            Console.WriteLine("pojo: " + pojo);


            // 反序列化 Deserialize: Json String -> Student
            JObject jo = JObject.FromObject(stu);
            Student sjson = jo.ToObject<Student>(); // json 转 对象

            Console.WriteLine(sjson);
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ExportData_Click(object sender, EventArgs e)
        {

            //string fileContont = null;
            //string fileName = TempFileDir + "\\searchResult.json";
            //FileInfo fi = new FileInfo(fileName);
            //string newFileName = TempFileDir + "\\" + fi.Name.Replace(fi.Extension, "");
            //FileStream fp = fi.OpenRead();
            //using (StreamReader sr = new StreamReader(fp))
            //{
            //    fileContont = sr.ReadToEnd();
            //}
            //fileContont = fileContont.Replace("\r\n", "").Replace(" ", "");
            ////List<DataClass> dataClassList = new List<DataClass>();
            ////JObject jo = JObject.FromObject(new List<DataClass>());
            //var data = JsonConvert.DeserializeObject<List<DataClass>>(fileContont); // json list 转 List<className>

            //string jsonstr = JsonConvert.SerializeObject(new List<DataClass>());
            //List<DataClass> pojo = JsonConvert.DeserializeObject<List<DataClass>>(jsonstr);

        }
    }
}
