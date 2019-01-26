using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= {1,3,1,9,6,59,7,4,8,6,9,-8,0};
            Sorter.SelectionSort(array);
            foreach(int i in array)
                Console.WriteLine(i);
            
        }
    }
}
