using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List
    {
        private int count = 0;
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

        private bool IsEmpty()
        {
            if(Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetSize()
        {
            return count;
        }
        
        public void AddFirst(int value)
        {
            if(Head == null)
            {
                Head = new Node(value);
                count++;
            }
            else
            {
                Node p = Head;
                Head = new Node(value);
                Head.Next = p;
                count++;
            }
            
        }
        public void AddLast(int value)
        {
            if (IsEmpty())
            {
                Head = new Node(value);
            }
            else
            {
                Node p = Head;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = new Node(value);
            }
            count++;
            
        }

        public void DeleteHead()
        {
            Head = Head.Next;
            count--;
        }


        public void Print()
        {
            Node p = Head;
            while(p != null)
            {
                Console.Write(p.Value + "\t");
                p = p.Next;
            }

        }

    }
}
