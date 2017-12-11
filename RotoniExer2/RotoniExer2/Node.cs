using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoniExer2
{
    public class Node //This is where I declared my Node class.
    {
        public int Data;
        public Node Left;
        public Node Right;


        public Node(int data) //Each node has an integer value and it has two pointers, left and right.
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

}
