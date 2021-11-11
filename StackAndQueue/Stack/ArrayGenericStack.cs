using Array;

namespace StackAndQueue.Stack
{
    class ArrayGenericStack<T> : IStack<T>
    {
        private ArrayGenericSample<T> arrayGeneric;

        public ArrayGenericStack(int capacity)
        {
            arrayGeneric = new ArrayGenericSample<T>(capacity);
        }

        public ArrayGenericStack()
        {
            arrayGeneric = new ArrayGenericSample<T>();
        }

        public int Count => arrayGeneric.Count;
        public bool IsEmpty => arrayGeneric.IsEmpty;

        public void Push(T element)
        {
            arrayGeneric.AddLast(element);
        }

        public T Pop()
        {
            return arrayGeneric.RemoveLast();
        }

        public T Peek()
        {
            return arrayGeneric.GetLast();
        }

        public override string ToString()
        {
            return $"Stack: {arrayGeneric.ToString()} top";
        }
    }
}