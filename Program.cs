using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array= {1,45,5,0,8,9,8,9,-8,-7,-4};
                Sorter.BucketSort(array);
             foreach(int i in array)
                 Console.WriteLine(i);
            
        }
    }
}
