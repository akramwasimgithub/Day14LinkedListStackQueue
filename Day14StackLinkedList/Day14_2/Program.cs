using System;

namespace Day14Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            linkedListStack link = new linkedListStack();
            link.Push(70);
            link.Push(30);
            link.Push(56);
            link.Display();
           /* link.peek();
            link.Pop();*/
            link.IsEmpty();
            link.Display();



        }
    }
}
