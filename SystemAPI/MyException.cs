using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAPI
{
    class MyException : Exception
    {
    }

    class NotFoundException : Exception
    {
        private string message;
        public NotFoundException() {}

        public NotFoundException(string message = "") : base(message)
        {
            Console.WriteLine("NotFoundException: 未找到", message);
        }
    }
}
