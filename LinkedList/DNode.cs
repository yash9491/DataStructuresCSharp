using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class DNode
    {
        public DNode prev;
        public int info;
        public DNode next;

        public DNode(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
