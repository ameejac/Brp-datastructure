using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList obj = new LinkedList();
            obj.Insert(20);
            obj.AddLast(30);
            obj.AddFront(10);
            obj.Display();

        }
    }
}
