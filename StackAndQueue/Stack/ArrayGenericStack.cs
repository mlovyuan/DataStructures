using Array;

namespace StackAndQueue.Stack
{
    class ArrayGenericStack<T> : IStack<T>
    {
        private ArrayGenericSample<T> _arrayGeneric;

        public ArrayGenericStack(int capacity)
        {
            _arrayGeneric = new ArrayGenericSample<T>(capacity);
        }

        public ArrayGenericStack()
        {
            _arrayGeneric = new ArrayGenericSample<T>();
        }

        public int Count => _arrayGeneric.Count;
        public bool IsEmpty => _arrayGeneric.IsEmpty;

        public void Push(T element)
        {
            _arrayGeneric.AddLast(element);
        }

        public T Pop()
        {
            return _arrayGeneric.RemoveLast();
        }

        public T Peek()
        {
            return _arrayGeneric.GetLast();
        }

        public override string ToString()
        {
            return $"Stack: {_arrayGeneric.ToString()} top";
        }
    }
}