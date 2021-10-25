using System;
using System.Text;

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
            if (index < 0 || index >= N)
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

        public T Get(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法的索引值");
            }

            Node currentNode = head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.next;

            return currentNode.element;
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

            Node currentNode = head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.next;

            currentNode.element = newElement;
        }

        public bool Contains(T element)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.element.Equals(element))
                    return true;
                currentNode = currentNode.next;
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
                deleteNode = head;
                head = head.next;
            }
            else
            {
                Node previousNode = head;
                for (int i = 0; i < index - 1; i++)
                    previousNode = previousNode.next;
                deleteNode = previousNode.next;
                previousNode.next = deleteNode.next;
            }
            N--;
            return deleteNode.element;
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
            if (head == null)
                return;
            if (head.element.Equals(element))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node currentNode = head;
                Node PreviousNode = null;
                while (currentNode != null)
                {
                    if (currentNode.element.Equals(element))
                        break;
                    PreviousNode = currentNode;
                    currentNode = currentNode.next;
                }
                if (currentNode != null)
                {
                    PreviousNode.next = currentNode.next;
                    N--;
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            Node currentNode = head;
            while (currentNode != null)
            {
                result.Append($"{currentNode} -> ");
                currentNode = currentNode.next;
            }
            result.Append("Null");
            return result.ToString();
        }
    }
}
