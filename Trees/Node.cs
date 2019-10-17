using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int data;

        public Node(int data)
        {
            this.Left = null;
            this.Right = null;
            this.data = data;
        }
    }
}
