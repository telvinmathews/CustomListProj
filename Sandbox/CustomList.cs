using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int count;
        private int capacity;
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
        }

        // member methods (CAN DO)
        public void Add(T item)
        {

        }

        public void Remove(T item)
        {

        }

    }
}
