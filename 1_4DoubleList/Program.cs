using System;
using System.Collections;
using System.Collections.Generic;
namespace DoubleList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        LinkedListNode<T> _head;
        LinkedListNode<T> _tail;
        public int Count { get; private set; }

        #region Add First
        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            LinkedListNode<T> temp = _head;
            _head = node;
            _head.Next = temp;
            if (Count == 0)
                _tail = _head;
            else
                temp.Previous = _head;
            Count++;
        }
        #endregion
        #region Add Last
        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (_tail != null)
            {
                _tail.Next = node;
                node.Previous = _tail;
            }
            else
            {
                _head = node;
            }
            _tail = node;
            Count++;
        }
        #endregion
        #region Clear 
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> text = new LinkedList<string> { };
            text.AddFirst("hello");
            text.AddFirst("Denis");
            text.AddLast("!");
            Display(text);
            Console.WriteLine(text.Count);
            text.Clear();
            Console.WriteLine(text.Count);
            text.AddLast("Hello");
            text.AddLast("Denis");
            text.AddLast("!");
            Display(text);
            Console.ReadKey();
        }

        private static void Display(LinkedList<string> text)
        {
            foreach (string str in text)
                Console.Write(str + " ");
        }
    }
}
