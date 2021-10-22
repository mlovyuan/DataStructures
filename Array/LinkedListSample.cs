using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class LinkedListSample<T>
    {
        private class Node
        {
            public T element;
            public Node next;

            public Node(T element, Node next)
            {
                this.element = element;
                this.next = next;
            }

            public Node(T element)
            {
                this.element = element;
                this.next = null;
            }

            public override string ToString()
            {
                return element.ToString();
            }
        }

        private Node head;
        private int N;

        public LinkedListSample()
        {
            head = null;
            N = 0;
        }

        public int Count => N;
        public bool IsEmpty => N == 0;
    }
}
