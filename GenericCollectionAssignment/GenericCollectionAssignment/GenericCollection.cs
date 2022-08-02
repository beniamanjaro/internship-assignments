using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionAssignment
{
    public class GenericCollection<T>
    {
        private T[] _array;

        public GenericCollection(T[] array)
        {
            _array = array;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= _array.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return _array[index];
        }


        public void Set(T item, int index)
        {
            _array[index] = item;
        }

        public int GetLength()
        {
            return _array.Length;
        }


        public void Swap(int a, int b)
        {
            T temp = _array[a];
            _array[a] = _array[b];
            _array[b] = temp;
        }

        public void Swap(T a, int b)
        {
            int itemAIndex = Array.IndexOf(_array, a);

            if (itemAIndex == -1)
            {
                throw new Exception("Element not found");
            }

            Swap(itemAIndex, b);
        }

        public void Swap(int a, T b)
        {
            int itemBIndex = Array.IndexOf(_array, b);

            if(itemBIndex == -1)
            {
                throw new Exception("Element not found");
            }

            Swap(a, itemBIndex);
        }

        public void Swap(T a, T b)
        {
            int itemAIndex = Array.IndexOf(_array, a);
            int itemBIndex = Array.IndexOf(_array, b);

            if (itemAIndex == -1 || itemBIndex == -1)
            {
                throw new Exception("Element not found");
            }

            Swap(itemAIndex, itemBIndex);

        }

    }
}