using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= {1,3,1,2,6,7,4,9,4,6};
            Sorter.BubbleSort(array);
            foreach(int i in array)
                Console.WriteLine(i);
            
        }
    }
}
