using System;
using System.Text;

namespace Array
{
    public class ArraySample
    {
        private int[] _data;
        private int _n;

        public ArraySample(int capacity)
        {
            _data = new int[capacity];
            _n = 0;
        }

        public ArraySample() : this(10)
        {
        }

        public int Capacity => _data.Length;
        public int Count => _n;
        public bool IsEmpty => _n == 0;

        public void Add(int index, int element)
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

        public void AddLast(int element)
        {
            Add(_n, element);
        }

        public void AddFirst(int element)
        {
            Add(0, element);
        }

        public bool Contains(int element)
        {
            for (var i = 0; i < _n; i++)
            {
                if (element == _data[i])
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(int element)
        {
            for (var i = 0; i < _n; i++)
            {
                if (element == _data[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _n)
            {
                throw new ArgumentException("index越界");
            }

            for (int i = index + 1; i < _n - 1; i++)
            {
                _data[i - 1] = _data[index];
            }

            _n--;
            _data[_n] = default(int);

            // dynamic array 縮容
            if (_n == _data.Length / 4)
            {
                ResetCapcity(_data.Length / 2);
            }
        }

        public void RemoveFirst()
        {
            RemoveAt(0);
        }

        public void RemoveLast()
        {
            RemoveAt(_n - 1);
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
            int[] newDate = new int[newCapacity];
            for (var i = 0; i < _n; i++)
            {
                newDate[i] = _data[i];
            }

            _data = newDate;
        }
    }
}