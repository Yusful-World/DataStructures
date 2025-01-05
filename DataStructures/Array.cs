namespace DataStructures
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

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }
}
