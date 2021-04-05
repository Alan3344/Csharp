using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbsInt
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassAbs cla = new ClassAbs();
            cla.Fly();
            cla.Run();

            // 调用
            int[] data = { 0x12, 0x2c, 0x34, 0xd3 };
            IAudioPlayer player = new XiaoMiPlayer(); // 变量类型是子类 new的是父类
            player.Play(data);

            Af.Example.Item item = new Af.Example.Item();
            item.id = 222;
            item.name = "xyz";


            // 索引器
            Af.MyArray arr = new Af.MyArray(4);
            arr[0] = 12;
            arr[1] = 29;
            arr[2] = 10;
            arr[3] = 30;
            string s = "";
            for (int i = 0; i < arr.Size(); i++)
            {
                s += arr[i] + " ";
            }
            Console.WriteLine(s);


            // 运算符重载
            Opera.Multi m1 = new Opera.Multi(2, 2);
            Opera.Multi m2 = new Opera.Multi(5, 6);
            Console.WriteLine("res: {0}", m1 * m2);
            Console.WriteLine("res: {0}", m1 / m2);

        }
    }
}
