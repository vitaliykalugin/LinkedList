using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List
    {
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    count = value;
                }
            }
        }
        private Node Head { get; set; }

        public Node this[int index]
        {
            get
            {
                if(index > Count - 1)
                {
                    return null;
                }
                else
                {
                    Node p = Head;
                    while (index > 0)
                    {
                        p = p.Next;
                        index--;
                    }
                    return p;
                }
                
            }
        }

        public List() {
            
        }

        public List(params int[] values)
        {
            Head = new Node();
            ListRecursive(Head, values, 0);
            Count = values.Length;                  
        }
        private void ListRecursive(Node n, int[] values, int i)
        {
            n.Value = values[i];
            if (i != values.Length - 1)
            {
                n.Next = new Node();
                ListRecursive(n.Next, values, i + 1);
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
        public int IndexOf(int value)
        {
            return IndexOfRecursive(Head, value, 0);
        }
        private int IndexOfRecursive(Node p, int value, int index)
        {
            if(p == null)
            {
                return -1;
            }
            else if(p.Value == value)
            {
                return index;
            }
            return IndexOfRecursive(p.Next, value, ++index);
        }

        public override bool Equals(object other)
        {
            if(other == null)
            {
                return false;
            }
            else
            {
                Node p = Head;
                Node h = ((List)other).Head;
                while(p != null)
                {
                    if(p.Value != h.Value)
                    {
                        return false;
                    }
                    p = p.Next;
                    h = h.Next;
                }
                return true;
            }
        }
        public override int GetHashCode()
        {
            return new { Count, Head }.GetHashCode();
        }

        public void AddFirst(int value)
        {
            if(IsEmpty())
            {
                Head = new Node(value);
            }
            else
            {
                Node p = Head;
                Head = new Node(value) { Next = p };
            }
            Count++;
            
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
            Count++;
            
        }

        public void DeleteHead()
        {
            if (IsEmpty())
            {
                return;
            }
            else if(Count >= 2)
            {
                Head = Head.Next;
                Count--;
            }
            else
            {
                Head = null;
                return;
            }
 
        }
        public void DeleteByIndex(int p)
        {
            if(p == 0)
            {
                DeleteHead();
            }
            else if(p > Count - 1 || p < 0)
            {
                return;
            }
            else
            {
                Node prev = Head;
                Node n = Head.Next;
                while(p > 1)
                {
                    prev = n;
                    n = n.Next;
                    p--;
                }
                prev.Next = n.Next;
                Count--;
            }
            
        }

        
        public List GetCopy()
        {
            List newList = new List();
            Node p = Head;
            Node h = new Node();
            newList.Head = h;
            while(p != null)
            {
                h.Value = p.Value;
                p = p.Next;
                if(p!= null)
                {
                    h.Next = new Node();
                    h = h.Next;
                }                
            }
            newList.Count = Count;
            return newList;
        }

    }
}
