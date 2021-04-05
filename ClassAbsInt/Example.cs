using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Af
{
    public class Example
    {

        // 内部类型 的全称: 命名空间.外部类名.类名  类嵌套
        // Af.Example.Item  Af.Example.IPlayer
        public class Item
        {
            internal int id;
            internal string name;
            public class My { }
        }

        public class IPlayer { }
    }

    public class MyArray
    {
        private int[] items;
        public MyArray(int capacity)
        {
            items = new int[capacity];
        }

        // 索引器(类似于容器的API,写法简洁)
        public int this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public int[] Items { get; set; }

        public int Size()
        {
            return items.Length;
        }

    }
}
