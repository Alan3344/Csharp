using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Af;

// C#里的类库,为DLL(动态链接库)文件,相当于Java里的JAR文件
namespace UserDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.Test();
        }
    }
}
