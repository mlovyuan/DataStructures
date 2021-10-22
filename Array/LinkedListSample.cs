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

        public void Add(int index, T inputElement)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法的索引值");
            }

            if (index == 0)
            {
                //var headNode = new Node(inputElement);
                //headNode.next = head;
                //head = headNode;

                head = new Node(inputElement, head);
            }
            else
            {
                var preNode = head;
                for (int i = 0; i < index - 1; i++)
                    preNode = preNode.next;

                preNode.next = new Node(inputElement, preNode.next);
            }
            N++;
        }

        public void AddFirst(T inputElement)
        {
            Add(0, inputElement);
        }

        public void AddLast(T inputElement)
        {
            Add(N, inputElement);
        }
    }
}
