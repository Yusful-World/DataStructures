using System;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Array numbers = new Array(5);
            numbers.Insert(3);
            numbers.Insert(4);
            numbers.Insert(5);
            numbers.Insert(6);
            numbers.Insert(7);
            numbers.Insert(8);
            numbers.Insert(9);
            numbers.Insert(10);

            Console.WriteLine(numbers.IndexOf(10));
            //numbers.RemoveAt(10);

            //numbers.Print();
        }

    }
}
