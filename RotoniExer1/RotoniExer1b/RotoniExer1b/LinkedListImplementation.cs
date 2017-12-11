using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoniExer1b
{
    public class LinkedListImplementation //This is where I created my methods
    {
        protected Node unahan { get; set; }
        protected Node dulo { get; set; }
        public int size;
        

        public LinkedListImplementation() 
        {
            unahan = null;
            dulo = null;
            size = 0;
        }

        public void EnQ (object name, object order) //This is where you create a new node or enqueue
        {
            Node newNode = new Node();
            newNode.Data = new Orders();
            newNode.Data.customername = name;
            newNode.Data.order = order;
             
            if (dulo != null)
            {
                dulo.Next = newNode;
            }
            dulo = newNode;
            if (unahan==null)
            {
                unahan = newNode;
            }

            size = size + 1;
        }

        public object DeQ() //This is where you delete the first node or dequeue
        {
            if (unahan==null)
            {
                return 0;
            }
            
                object currentData = unahan.Data;
                unahan = unahan.Next;
                size = size - 1;
                return currentData;
            
            
        }

        public void Clear() //This is where you free up the whole queue
        {
            unahan = null;
            dulo = null;
            size = 0;
        }

        public object FirstInTheLine() //This will show who is on the first in line
        {
            if (unahan == null)
              {
                  return null;
                  }

            return unahan.Data.customername;
        }

        public object OrderNungUna() //This will show what's the order of the first in line
        {
  
            return unahan.Data.order;
        }

    }
}
