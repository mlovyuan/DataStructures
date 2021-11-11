using Array;

namespace StackAndQueue.Stack
{
    class LinkedListStack<T> : IStack<T>
    {
        private LinkedListSample<T> _linkedListSample;

        public LinkedListStack()
        {
            _linkedListSample = new LinkedListSample<T>();
        }

        public int Count => _linkedListSample.Count;
        public bool IsEmpty => _linkedListSample.IsEmpty;

        public void Push(T element)
        {
            _linkedListSample.AddFirst(element);
        }

        public T Pop()
        {
            return _linkedListSample.RemoveFirst();
        }

        public T Peek()
        {
            return _linkedListSample.GetFirst();
        }

        public override string ToString()
        {
            return $"Stack: top {_linkedListSample.ToString()}";
        }
    }
}