using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List
    {
        private int count;
        public Node Head;

        public List() {
            
        }

        public List(params int[] values)
        {
            Head = new Node();
            CreateListNodes(Head, values, 0);
            count = values.Length;                  
        }

        private void CreateListNodes(Node n, int[] values, int i)
        {
            n.Value = values[i];
            if (i != values.Length - 1)
            {
                n.Next = new Node();
                CreateListNodes(n.Next, values, i + 1);
            }

        }

        public void Print()
        {
            Node p = Head;
            while(p != null)
            {
                Console.WriteLine(p.Value);
                p = p.Next;
            }

        }

    }
}
