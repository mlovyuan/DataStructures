namespace StackAndQueue.Queue
{
    interface IQueue<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Enqueue(T element);
        T Dequeue();
        T Peek();
    }
}