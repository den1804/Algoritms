using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListClass
{
    class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; internal set; }
        public LinkedListNode<T> Next { get; set; }
    }
}
