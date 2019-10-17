using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine("List is  ");
            p = start;
            while(p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public void CreateLinkedList()
        {
            int i, n, data;

            Console.WriteLine("Enter Number of Nodes");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for(i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAtBegining(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if(start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while(p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " Not present int eh list");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if(x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;

            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(x + "not present in the list");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if(k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            
            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++)
                p = p.link;

            if (p == null)
                Console.WriteLine("You can insert only upto" + i + "th position");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }
    }
}
