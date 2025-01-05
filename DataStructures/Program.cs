using System;
using System.Collections;

namespace DataStructures
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] c = { 7, 8, 9 };
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Insert(1, 4);

            arrayList.InsertRange(2, c);

            arrayList.Remove(1);
            arrayList.RemoveAt(0);
            

            foreach (int item in arrayList)
            Console.WriteLine(item);

            Console.WriteLine(arrayList.Count);


            //Array numbers = new Array(5);
            //numbers.Insert(3);
            //numbers.Insert(4);
            //numbers.Insert(5);
            //numbers.Insert(6);
            //numbers.Insert(7);
            //numbers.Insert(8);
            //numbers.Insert(9);
            //numbers.Insert(10);

            //Console.WriteLine(numbers.IndexOf(10));
            //numbers.RemoveAt(10);

            //numbers.Print();
        }

    }
}
