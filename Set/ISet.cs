namespace Set
{
    interface ISet<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Add(T element);
        void Remove(T element);
        bool Contaion(T element);
    }
}