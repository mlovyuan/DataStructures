using Array;

namespace StackAndQueue.Queue
{
    class ArrayGenericQueue<T>:IQueue<T>
    {
        private ArrayGenericSample<T> arrayGeneric;

        public ArrayGenericQueue()
        {
            arrayGeneric = new ArrayGenericSample<T>();
        }

        public int Count { get; }
        public bool IsEmpty { get; }
        public void Enqueue(T element)
        {
            throw new System.NotImplementedException();
        }

        public T Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }
    }
}