using System;

namespace LinkedListNode
{
    public class LinkedListNode<T>
    {
        public LinkedListNode (T value)
        {
            Value = value;
        }

        public T Value { get; internal set; }
        public LinkedListNode<T> Next { get; internal set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<string> first = new LinkedListNode<string>("First");
            LinkedListNode<string> second = new LinkedListNode<string>("Second");

            first.Next = second;

            Console.WriteLine(first.Value);
            Console.WriteLine(first.Next.Value);

            Console.ReadKey();
        }
    }
}
