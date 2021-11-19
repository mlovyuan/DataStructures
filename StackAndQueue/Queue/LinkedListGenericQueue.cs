using Array;
using System;

namespace StackAndQueue.Queue
{
    class LinkedListGenericQueue<T>:IQueue<T>
    {
        private LinkedListSample<T> LinkedList;

        public LinkedListGenericQueue()
        {
            LinkedList = new LinkedListSample<T>();
        }

        public int Count => LinkedList.Count;

        public bool IsEmpty => LinkedList.IsEmpty;

        public T Dequeue()
        {
            return LinkedList.RemoveFirst();
        }

        public void Enqueue(T element)
        {
            LinkedList.AddLast(element);
        }

        public T Peek()
        {
            return LinkedList.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue front {LinkedList} tail";
        }
    }
}
