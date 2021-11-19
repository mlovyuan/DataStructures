using Array;

namespace StackAndQueue.Queue
{
    class LinkedListGenericQueue<T> : IQueue<T>
    {
        private LinkedListSample<T> _linkedList;

        public LinkedListGenericQueue()
        {
            _linkedList = new LinkedListSample<T>();
        }

        public int Count => _linkedList.Count;

        public bool IsEmpty => _linkedList.IsEmpty;

        public T Dequeue()
        {
            return _linkedList.RemoveFirst();
        }

        public void Enqueue(T element)
        {
            _linkedList.AddLast(element);
        }

        public T Peek()
        {
            return _linkedList.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue front {_linkedList} tail";
        }
    }
}
