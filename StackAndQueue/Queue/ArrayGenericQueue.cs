using Array;

namespace StackAndQueue.Queue
{
    class ArrayGenericQueue<T>:IQueue<T>
    {
        private ArrayGenericSample<T> _arrayGeneric;

        public ArrayGenericQueue(int Capacity)
        {
            _arrayGeneric = new ArrayGenericSample<T>(Capacity);
        }
        
        public ArrayGenericQueue()
        {
            _arrayGeneric = new ArrayGenericSample<T>();
        }

        public int Count => _arrayGeneric.Count;
        public bool IsEmpty => _arrayGeneric.IsEmpty;
        public void Enqueue(T element)
        {
            _arrayGeneric.AddLast(element);
        }

        public T Dequeue()
        {
            return _arrayGeneric.RemoveFirst();
        }

        public T Peek()
        {
            return _arrayGeneric.GetFirst();
        }

        public override string ToString()
        {
            return $"Queue: front {_arrayGeneric} tail";
        }
    }
}