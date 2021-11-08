using System;

namespace day14QueueLinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            
            queue.Display();
        }
    }
}
