using Array;

namespace StackAndQueue.Queue
{
    class ArrayGenericCircularQueue<T> : IQueue<T>
    {
        private ArrayForCircularQueueGenericSample<T> arrayCircularQueueGeneric;

        public ArrayGenericCircularQueue(int Capacity)
        {
            arrayCircularQueueGeneric = new ArrayForCircularQueueGenericSample<T>(Capacity);
        }

        public ArrayGenericCircularQueue()
        {
            arrayCircularQueueGeneric = new ArrayForCircularQueueGenericSample<T>();
        }

        public int Count => arrayCircularQueueGeneric.Count;

        public bool IsEmpty => arrayCircularQueueGeneric.IsEmpty;

        public void Enqueue(T element)
        {
            arrayCircularQueueGeneric.AddLast(element);
        }

        public T Dequeue()
        {
            return arrayCircularQueueGeneric.RemoveFirst();
        }

        public T Peek()
        {
            return arrayCircularQueueGeneric.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue: front {arrayCircularQueueGeneric} tail";
        }
    }
}
