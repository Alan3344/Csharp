using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace WebSpider
{
    class Baidu
    {
        public static string SendHttPost(string url, string pjson)
        {
            WebClient web = new WebClient();
            web.Headers.Add("Content-Type", "text/html;charset=utf-8");
            web.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.190 Safari/537.36");
            byte[] byteData = Encoding.UTF8.GetBytes(pjson);
            byte[] content = web.UploadData(url, "post", byteData);
            Console.WriteLine(content.Length);
            return Encoding.UTF8.GetString(content);
        }

        public static string Get(string url)
        {
            string result = "";
            WebRequest req = WebRequest.Create(url);
            WebResponse res = req.GetResponse();
            Stream stream = res.GetResponseStream();
            try
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }

    }
}
