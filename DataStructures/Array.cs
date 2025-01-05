﻿namespace DataStructures
{
    public class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
            }

            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("index", "index cannot be less than 0 or greater than size of array");

            for (int i = index; i < count; i++)
                items[i] = items[i + 1];
            count--;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                {
                    return i;
                }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }
}
