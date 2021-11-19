using System;
using System.Text;

namespace Array
{
    public class LinkedListSample<T>
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
        private int N;

        public LinkedListSample()
        {
            _head = null;
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

                _head = new Node(inputElement, _head);
            }
            else
            {
                var preNode = _head;
                for (int i = 0; i < index - 1; i++)
                    preNode = preNode._next;

                preNode._next = new Node(inputElement, preNode._next);
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

        public T Get(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法的索引值");
            }

            Node currentNode = _head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode._next;

            return currentNode._element;
        }

        public T GetFirst()
        {
            return Get(0);
        }

        public T GetLast()
        {
            return Get(N - 1);
        }

        public void Set(int index, T newElement)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法的索引值");
            }

            Node currentNode = _head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode._next;

            currentNode._element = newElement;
        }

        public bool Contains(T element)
        {
            Node currentNode = _head;
            while (currentNode != null)
            {
                if (currentNode._element.Equals(element))
                    return true;
                currentNode = currentNode._next;
            }
            return false;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法的索引值");
            }

            Node deleteNode;
            if (index == 0)
            {
                deleteNode = _head;
                _head = _head._next;
            }
            else
            {
                Node previousNode = _head;
                for (int i = 0; i < index - 1; i++)
                    previousNode = previousNode._next;
                deleteNode = previousNode._next;
                previousNode._next = deleteNode._next;
            }
            N--;
            return deleteNode._element;
        }

        public T RemoveFirst()
        {
            return RemoveAt(0);
        }

        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public void Remove(T element)
        {
            if (_head == null)
                return;
            if (_head._element.Equals(element))
            {
                _head = _head._next;
                N--;
            }
            else
            {
                Node currentNode = _head;
                Node PreviousNode = null;
                while (currentNode != null)
                {
                    if (currentNode._element.Equals(element))
                        break;
                    PreviousNode = currentNode;
                    currentNode = currentNode._next;
                }
                if (currentNode != null)
                {
                    PreviousNode._next = currentNode._next;
                    N--;
                }
            }
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
