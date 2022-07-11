using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Size { get; set; }

        public LinkedList()
        {
            Head = null; Tail = null; Size = 0;
        }

        /// <summary>
        /// check if linked list is empty
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty() => Size == 0;

        /// <summary>
        /// Get the length of Linked list
        /// </summary>
        /// <returns></returns>
        public int Length() => Size;

        /// <summary>
        /// Display linked list in arrow (=>) form
        /// </summary>
        public void Display()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write(p.Element + " ==> ");
                p = p.Next;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// add node at the last of the linked list.
        /// </summary>
        /// <param name="e"></param>
        public void AddLast(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty()) Head = newest; 
            else Tail.Next = newest;

            Tail = newest;
            Size = Size + 1;
        }

        /// <summary>
        /// add node to the begining of the linked list
        /// </summary>
        /// <param name="e"></param>
        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                Head = newest;
                Tail = newest;
            }
            else
            {
                //var tmp = Head;
                //Head = newest;
                //Head.Next = tmp;

                newest.Next = Head;
                Head = newest;
            }

            Size = Size + 1;
        }   

        /// <summary>
        /// Add node before specified position. and liked to the node at that position.
        /// </summary>
        public void AddMiddle(int e, int position)
        {
            var newest = new Node(e, null);

            if (IsEmpty())
            {
                Head = newest;
                Tail = newest;
            }
            else
            {
                var p = Head;
                int i = 1;

                while (i < position - 1)
                {
                    p = p.Next;
                    i++;
                }

                newest.Next = p.Next;
                p.Next = newest;
            }

            Size++;

        }        
       
        /// <summary>
        /// Lookup an element in linked list.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool Lookup(int e)
        {
            if (IsEmpty())
            {
                return false;
            }

            var tmp = Head;

            while(tmp != null)
            {
                if (tmp.Element == e) return true;

                tmp = tmp.Next;
            }
            return false;
        }

        /// <summary>
        /// Delete First element from linked list
        /// </summary>
        /// <returns></returns>
        public int DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked list is empty");
                return -1;
            }

            var e = Head.Element;
            Head = Head.Next;
            Size--;

            if (IsEmpty()) Tail = null;

            return e;
        }
    }
}
