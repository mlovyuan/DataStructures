using System;
using System.Text;

namespace Array
{
    public class ArrayGenericSample<T>
    {
        private T[] _data;
        private int _n;

        public ArrayGenericSample(int capacity)
        {
            _data = new T[capacity];
            _n = 0;
        }

        public ArrayGenericSample() : this(10)
        {
        }

        public int Capacity => _data.Length;
        public int Count => _n;
        public bool IsEmpty => _n == 0;

        public void Add(int index, T element)
        {
            if (index < 0 || index > _n)
            {
                throw new ArgumentException("index越界");
            }
            else if (_n == _data.Length)
            {
                // static array
                // throw new ArgumentException("Array已滿");

                // dynamic array 擴容        
                ResetCapcity(2 * _data.Length);
            }

            for (int i = _n - 1; i >= index; i--)
            {
                _data[i + 1] = _data[i];
            }

            _data[index] = element;
            _n++;
        }

        public void AddLast(T element)
        {
            Add(_n, element);
        }

        public void AddFirst(T element)
        {
            Add(0, element);
        }

        public bool Contains(T element)
        {
            for (var i = 0; i < _n; i++)
            {
                if (element.Equals(_data[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public T Get(int index)
        {
            if (index < 0 || index > _n)
            {
                throw new ArgumentException("index越界");
            }

            return _data[index];
        }

        public T GetFirst()
        {
            return Get(0);
        }

        public T GetLast()
        {
            return Get(_n - 1);
        }

        public int IndexOf(int element)
        {
            for (var i = 0; i < _n; i++)
            {
                if (element.Equals(_data[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > _n)
            {
                throw new ArgumentException("index越界");
            }

            T deleteItem = _data[index];
            for (int i = index; i < _n; i++)
            {
                _data[i] = _data[index + 1];
            }

            _data[_n] = default(T);
            _n--;

            // dynamic array 縮容
            if (_n == _data.Length / 4)
            {
                ResetCapcity(_data.Length / 2);
            }

            return deleteItem;
        }

        public T RemoveFirst()
        {
            return RemoveAt(0);
        }

        public T RemoveLast()
        {
            return RemoveAt(_n - 1);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Array: Count={_n.ToString()}, Capacity={_data.Length.ToString()}\n [");
            for (int i = 0; i < _n; i++)
            {
                result.Append(_data[i]);
                if (i != _n - 1)
                {
                    result.Append(",");
                }
            }

            result.Append("]");
            return result.ToString();
        }

        private void ResetCapcity(int newCapacity)
        {
            T[] newDate = new T[newCapacity];
            for (var i = 0; i < _n; i++)
            {
                newDate[i] = _data[i];
            }

            _data = newDate;
        }
    }
}