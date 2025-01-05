using System;

namespace DataStructures
{
    public class Array
    {
        private readonly int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Array numbers = new Array(5);
            numbers.Print();
        }

    }
}
