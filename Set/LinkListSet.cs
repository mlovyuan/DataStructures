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

        public int Count => _linkedListSample.Count;
        public bool IsEmpty => _linkedListSample.IsEmpty;
        public void Add(T element)
        {
            if(!_linkedListSample.Contains(element))
                _linkedListSample.AddFirst(element);
        }

        public void Remove(T element)
        {
            _linkedListSample.Remove(element);
        }

        public bool Contaion(T element)
        {
            return _linkedListSample.Contains(element);
        }
    }
}