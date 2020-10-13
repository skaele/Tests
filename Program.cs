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

            foreach (var item in IndexOfValue(list, value)) Console.WriteLine(item);
        }

        private static List<int> IndexOfValue(List<int> list, int value) 
        {
            List<int> output = new List<int>();
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] == value) output.Add(index);
            }
            return output;
        }
    }
}
