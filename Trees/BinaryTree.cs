using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void InsertNode(int data)
        {
            Node node = new Node(data);

            if (Root == null)
                Root = node;
            else
            {
                
            }

        }
    }
}
