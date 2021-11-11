namespace StackAndQueue.Stack
{
    interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Push(T element);
        T Pop();
        T Peek();
    }
}