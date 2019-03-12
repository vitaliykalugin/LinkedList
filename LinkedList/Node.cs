using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next;

        public Node() { }

        public Node(int value)
        {
            Value = value;
        }

    }
}
