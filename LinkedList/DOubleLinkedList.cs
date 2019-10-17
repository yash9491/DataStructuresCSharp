using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class DOubleLinkedList
    {
        DNode start;

        DOubleLinkedList()
        {
            start = null;
        }

        public void InsertAtEnd()
        {
            DNode temp = new DNode(32);

            if (start == null)
            {
                start = temp;
            }

            DNode p;
            p = start;
            while (p != null)
            {
                p = p.next;
            }

            if (p != null)
            {
                p.next = temp;
                temp.prev = p;
            }
        }
        public void InsertAtBegin()
        {
            DNode temp = new DNode(32);

            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        
        public void InsertAfter()
        {
            DNode temp = new DNode(32);

            DNode p;
            p = start;
            while(p != null)
            {
                if (p.info == 21)
                    break;
                p = p.next;
            }

            if(p != null)
            {
                temp.next = p.next;
                p.next = temp;
                temp.prev = p;
                p.next.prev = temp;
            }
        }

        public void InsertBefore()
        {
            DNode temp = new DNode(22);
            DNode p;
            p = start;
            while (p != null)
            {
                if (p.info == 21)
                    break;
                p = p.next;
            }

            if (p != null)
            {
                temp.next = p;
                temp.prev = p.prev;
                p.prev.next = temp;
                p.prev = temp;
            }
        }
    }
}
