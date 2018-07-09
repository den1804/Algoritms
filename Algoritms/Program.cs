using System;

namespace Algoritms
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 5 };
            Node second = new Node { Value = 12 };
            Node last = new Node { Value = 18 };
            first.Next = second;
            second.Next = last;
            PrintList(first);
            Console.ReadKey();
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
