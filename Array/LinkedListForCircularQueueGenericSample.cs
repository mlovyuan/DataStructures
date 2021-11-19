using System;
using System.Text;

namespace Array
{
    public class LinkedListForCircularQueueGenericSample<T>
    {
        private class Node
        {
            public T _element;
            public Node _next;

            public Node(T element, Node next)
            {
                _element = element;
                _next = next;
            }

            public Node(T element)
            {
                _element = element;
                _next = null;
            }

            public override string ToString()
            {
                return _element.ToString();
            }
        }

        private Node _head;
        private Node _tail;
        private int N;

        public LinkedListForCircularQueueGenericSample()
        {
            _head = null;
            _tail = null;
            N = 0;
        }

        public int Count => N;

        public bool IsEmpty => N == 0;

        public void AddLast(T element)
        {
            var node = new Node(element);
            if (IsEmpty)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail._next = node;
                _tail = node;
            }
            N++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("This linkedlist is empty...");

            T element = _head._element;
            _head = _head._next;
            N--;

            if (_head == null)
                _tail = null;

            return element;
        }

        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("This linkedlist is empty...");

            return _head._element;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            Node currentNode = _head;
            while (currentNode != null)
            {
                result.Append($"{currentNode} -> ");
                currentNode = currentNode._next;
            }
            result.Append("Null");
            return result.ToString();
        }
    }
}
