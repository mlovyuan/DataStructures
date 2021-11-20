using Array;

namespace Set
{
    class LinkListSet<T> : ISet<T>
    {
        private LinkedListSample<T> _linkedListSample;


        public LinkListSet()
        {
            _linkedListSample = new LinkedListSample<T>();
        }

        public int Count { get; }
        public bool IsEmpty { get; }
        public void Add(T element)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new System.NotImplementedException();
        }

        public bool Contaion(T element)
        {
            throw new System.NotImplementedException();
        }
    }
}