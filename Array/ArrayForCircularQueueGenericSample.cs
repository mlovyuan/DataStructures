using System;
using System.Text;

namespace Array
{
    public class ArrayForCircularQueueGenericSample<T>
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

        public void AddLast(T element)
        {
            if (N == _data.Length)
                ResetCapacity(2 * _data.Length);

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

            if (N == _data.Length / 4)
            {
                ResetCapacity(_data.Length / 2);
            }

            return removeData;
        }

        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("This array is empty...");

            return _data[_first];
        }

        private void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < N; i++)
                newData[i] = _data[(_first + i) % _data.Length];

            _data = newData;
            _first = 0;
            _last = N;

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");
            for (int i = 0; i < N; i++)
            {
                result.Append(_data[(_first + i) % _data.Length]);
                if ((_first + i + 1) % _data.Length != _last)
                    result.Append(",");
            }

            result.Append("]");
            return result.ToString();
        }
    }
}
