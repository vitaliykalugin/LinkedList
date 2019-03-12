using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List(2, 3, 4);
            list.Print();

            Console.Read();
        }
    }
}
