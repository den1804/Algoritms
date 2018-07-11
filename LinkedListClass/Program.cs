using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListClass
{
    class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> _head;
        public LinkedListNode<T> _tail;
        public int Count { get; private set; }

        #region Add Element
        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }
        #endregion
        #region Remove Element
        public bool Revome(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (previous.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head.Next;
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        #endregion
        #region Contains
        public bool Contains(T value)
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                if(current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        #endregion
        #region Clear LinkedList
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        #endregion
        #region CopyTo
        public void CopyTo(T[] arr, int arrayIndex)
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                arr[arrayIndex++] = current.Value;
                current = current.Next;
            }
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
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
    class Program
    {
        public static void Display(LinkedList<int> list, string text)
        {
            Console.WriteLine(text);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            LinkedList<int> instanse = new LinkedList<int> { };
            instanse.Add(10);
            instanse.Add(14);
            instanse.Add(17);
            instanse.Add(19);
            Console.WriteLine(instanse.Revome(11));
            Console.WriteLine("Before remove " + instanse.Contains(19));
            Console.WriteLine(instanse.Revome(19));
            Console.WriteLine("After remove " + instanse.Contains(19));
            Display(instanse, "Adds");
            instanse.Clear();
            Display(instanse, "Cleared");
            Console.ReadKey();
        }
    }
}
