using System;

namespace Array
{
    class ArrayForCircularQueueGenericSample<T>
    {
        private T[] _data;
        private int _first;
        private int _last;
        private int N;

        public ArrayForCircularQueueGenericSample(int capacity)
        {
            _data = new T[capacity];

            _first = 0;
            _last = 0;
            N = 0;
        }
        public ArrayForCircularQueueGenericSample() : this(10) { }

        public int Count => N;

        public bool IsEmpty => N == 0;

        public void Add(T element)
        {
            _data[_last] = element;

            _last = (_last + 1) % _data.Length;
            N++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("This array is empty...");

            T removeData = _data[_first];
            _data[_first] = default(T);

            _first = (_first + 1) % _data.Length;
            N--;
            return removeData;
        }

        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("This array is empty...");

            return _data[_first];
        }
    }
}
