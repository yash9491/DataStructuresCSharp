using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class SingleLinkedList2
    {
        public Node Start;

        public SingleLinkedList2()
        {
            Start = null;
        }

        public void InsertAtEnd(int data)
        {
            Node node = new Node(data);

            if (Start == null)
                Start = node;
            else
            {
                Node p = Start;
                while (p.link != null)
                    p = p.link;

                p.link = node;
            }
        }

        public void InserAtBegining(int data)
        {
            Node node = new Node(data);
            node.link = Start;
            Start = node;
        }

        public void DisplayLinkedList()
        {
            Node p = Start;
            while(p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;
            }
        }

        public void InsertAtGivenPoint(int data, int point)
        {
            Node p = Start;
            Node node = new Node(data);


        }
    }
}
