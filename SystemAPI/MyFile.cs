using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 文件与目录操作: System.IO
 * File, FileInfo: 文件的创建,复制,删除,移动
 * Dictionary, DictionaryInfo: 目录的创建,删除,移动和枚举
 * Path 文件目录的路径处理
 * 
 */
namespace SystemAPI
{
    class CMyFile
    {
        private void F_()
        {
            string dirPath = "C:\\x\\y\\z.txt";
            Directory.CreateDirectory(dirPath); // Directory 提供静态方法
            DirectoryInfo dir = new DirectoryInfo(dirPath); // DirectoryInfo 提供实例方法
            dir.Create();

            string path1 = "", path2 = "", filePath="";
            File.Move(path1, path2);
            FileInfo fInfo = new FileInfo(filePath);
            long size = fInfo.Length;
            DateTime time = fInfo.LastWriteTime;
        }

        /*
         * FileStream: 文件流
         * BinaryReader/BinaryWriter: 二进制数据读写
         * StreamReader/StreamWriter: 文本数据按行读写
         * 打开文件流,写入数据,关闭文件流
         */
        public static void MyFileStream()
        {
            string fileName = "filename.text";
            FileInfo fi = new FileInfo(fileName); // 创建文件对象
            FileStream fp = fi.OpenWrite(); // 以只写方式打开文件
            using (StreamWriter sw = new StreamWriter(fp)) // 写入文件流
            {
                sw.Write("xyz"); // 使用using 写入文件内容,并且关闭文件流
            }
        }
    }
}
