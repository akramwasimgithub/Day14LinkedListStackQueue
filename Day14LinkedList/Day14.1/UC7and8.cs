using System;
using System.Collections.Generic;
using System.Text;

namespace Day14._1
{
    class UC7and8
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
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
            // Console.WriteLine("{0} inserted  into Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Link is empety");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }    
        
            internal Node Search(int value)
            {
                while(this.head != null)
                {
                    if(this.head.data == value)
                    {
                        return this.head;
                    }
                    this.head = this.head.next;
                }
                return null;
            }
        internal Node InsertAtParticularPosition(int position ,int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");

            if(position==1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;

            }
            else
            {
                while(position!=0)
                {
                    if(position==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("position out of range");
            }
            return head;
        }
        
    }
}
