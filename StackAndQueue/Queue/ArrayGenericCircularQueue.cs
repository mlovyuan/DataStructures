using Array;

namespace StackAndQueue.Queue
{
    class ArrayGenericCircularQueue<T> : IQueue<T>
    {
        private ArrayForCircularQueueGenericSample<T> _arrayCircularQueueGeneric;

        public ArrayGenericCircularQueue(int Capacity)
        {
            _arrayCircularQueueGeneric = new ArrayForCircularQueueGenericSample<T>(Capacity);
        }

        public ArrayGenericCircularQueue()
        {
            _arrayCircularQueueGeneric = new ArrayForCircularQueueGenericSample<T>();
        }

        public int Count => _arrayCircularQueueGeneric.Count;

        public bool IsEmpty => _arrayCircularQueueGeneric.IsEmpty;

        public void Enqueue(T element)
        {
            _arrayCircularQueueGeneric.AddLast(element);
        }

        public T Dequeue()
        {
            return _arrayCircularQueueGeneric.RemoveFirst();
        }

        public T Peek()
        {
            return _arrayCircularQueueGeneric.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue: front {_arrayCircularQueueGeneric} tail";
        }
    }
}
