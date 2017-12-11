using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoniExer1b
{
    public class Node // This is where I declared my node wherein you stored the data and pointer to the next node.
    {
        public Orders Data { get; set; }
        public Node Next;
    }

    public class Orders
    {
        public object customername { get; set; }
        public object order { get; set; }
    }
                
    
}
