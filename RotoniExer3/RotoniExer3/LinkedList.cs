using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoniExer3
{
    class LinkedList // This is my linked list implementation.
    {
        public int Count;
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void EnQ(int x) // This is where you add or enqueue the vertex.
        {
            Node newNode = new Node();
            newNode.Vertex = x;

            if (Tail != null)
            {
                Tail.Next = newNode;
            }

            Tail = newNode;

            if (Head == null)
            {
                Head = newNode;
            }

            Count++;
        }

        public void DeQ() // This is where you dequeue the vertex or remove the first data on the list.
        {
            int currentNumber = Head.Vertex;
            Head = Head.Next;
            Count--;
        }
    }
}
