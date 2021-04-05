using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbsInt
{
    class Opera
    {
        public class Multi
        {
            private int a, b;
            public Multi() { }
            public Multi(int num1, int num2)
            {
                a = num1;
                b = num2;
            }
            public static int operator *(Multi p1, Multi p2)
            {
                return (p1.a + p2.a) * (p1.b + p2.b);
            }
            public static float operator /(Multi p1, Multi p2)
            {
                return (p1.a + p2.a) / (p1.b + p2.b);
            }
            //public override string ToString()
            //{
            //    return this.a * this.b + "";
            //}
        }
    }
}
