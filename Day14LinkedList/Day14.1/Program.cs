using System;

namespace Day14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UC1 list = new UC1();
            list.Add(50);
            list.Add(36);
            list.Add(70);
            list.Display();

            Console.WriteLine("H==============l");
            /* UC2 a= new UC2();
             a.Add(50);
             a.Add(36);
             a.Add(70);
             a.pop();

             Console.Write("\nTop element is {0}\n", a.peek());*/

            Console.WriteLine("H==============l");
            UC2_3_4and5 remove = new UC2_3_4and5();
            remove.Add(50);
            remove.Add(36);
            remove.Add(70);
            remove.RemoveFirstNode();
            remove.Display();
            Console.Write( remove.RemoveFirstNode());
            Console.WriteLine("H==============l");


            UC6 removeLast = new UC6();
            removeLast.Add(50);
            removeLast.Add(36);
            removeLast.Add(70);
            removeLast.RemoveLastNode();
            removeLast.Display();
            Console.Write(removeLast.RemoveLastNode());

            UC7and8 search= new UC7and8();
            search.Add(50);
           /* search.Add(30);*/
            search.Add(70);
            search.Display();

            search.Search(30);
            search.InsertAtParticularPosition( 1, 40);
            search.Display();
        }
    }
}
