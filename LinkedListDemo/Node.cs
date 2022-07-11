using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class Node
    {
        public int Element { get; set; }
        public Node Next { get; set; }

        public Node(int e, Node n)
        {
            Element = e;
            Next = n;
        }
    }
}
