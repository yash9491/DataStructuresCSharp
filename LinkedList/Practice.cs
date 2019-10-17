using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Practice
    {
        Node start;
        public Practice()
        {
            start = null;
        }
        
        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
            }

            Node p;
            p = start;

            while(p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }

        public void DisplayList()
        {
            Node p;
            p = start;

            while(p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;
            }
        }

        public void InsertAfter()
        {
            Node p;
            p = start;

            if (start == null)
                Console.WriteLine();

            while(p.link != null)
            {
                if (p.info == 32)
                    break;
                p = p.link;
            }

            if(p != null)
            {
                Node temp = new Node(32);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore()
        {
            Node p;
            p = start;

            if (start == null)
                Console.WriteLine();

            while (p.link != null)
            {
                if (p.link.info == 32)
                    break;
                p = p.link;
            }

            if (p != null)
            {
                Node temp = new Node(32);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition()
        {

        }
    }
}
