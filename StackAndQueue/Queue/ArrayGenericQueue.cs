using Array;

namespace StackAndQueue.Queue
{
    class ArrayGenericQueue<T>:IQueue<T>
    {
        private ArrayGenericSample<T> arrayGeneric;

        public ArrayGenericQueue(int Capacity)
        {
            arrayGeneric = new ArrayGenericSample<T>(Capacity);
        }
        
        public ArrayGenericQueue()
        {
            arrayGeneric = new ArrayGenericSample<T>();
        }

        public int Count => arrayGeneric.Count;
        public bool IsEmpty => arrayGeneric.IsEmpty;
        public void Enqueue(T element)
        {
            arrayGeneric.AddLast(element);
        }

        public T Dequeue()
        {
            return arrayGeneric.RemoveFirst();
        }

        public T Peek()
        {
            return arrayGeneric.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue: front {arrayGeneric} tail";
        }
    }
}