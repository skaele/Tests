using System;
using System.Collections.Generic;

namespace MTC
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfList = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < sizeOfList; i++) list.Add(int.Parse(Console.ReadLine()));

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            list.RemoveAll(a => a == value);

            foreach (var item in list) Console.WriteLine(item);
        }
    }
}
