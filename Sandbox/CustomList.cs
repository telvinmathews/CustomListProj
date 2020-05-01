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
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // member methods (CAN DO)
        // MyCustomList customList = new MyCustomList();
        //customList.Add();
        public void Add(T item)
        {
            //what if my capacity reach its limit?
            
            if (count == capacity)
            {
                capacity *= 2;
                T[] moreitems = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    moreitems[i] = items[i];
                }
                items = moreitems;
            }
            items[count] = item;
            count++;

        }

        public void Remove(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    continue;
                }
            }
            items[count] = item;
            count--;
        }
    }
}
