using System;
using System.Collections.Generic;
using System.Text;

namespace day14QueueLinkedList2
{
    class QueueLinkedList
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {

                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
                internal void Display()
            {
                Node temp = this.head;
                if(temp ==null)
                {
                    Console.WriteLine("Queuen is  empty");
                    return;
                }


                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        
    }
}
