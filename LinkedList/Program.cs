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
            List list = new List(1,2,3,4,5);
            List newList = new List(2, 4, 5, 6);
            Console.WriteLine(list.Equals(newList));

            for(int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i].Value}\t");
            }
            Console.Read();
        }
    }
}
