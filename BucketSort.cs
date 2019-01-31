namespace Algorithms
{
    public static partial class Sorter 
    {
        public static void BucketSort( int[] array) 
        {
            int max=Max(array);
            int min=Min(array);
            int[]Quantity= new int[max-min+1];
            for(int i=0; i< array.Length; i++)
            {
                Quantity[array[i]+abs(min)]++;
            }
            int j=0;
            for(int i=0; i < Quantity.Length; i++)
            {
                for(; Quantity[i]>0; Quantity[i]-- , j++)
                {
                    array[j]=i+min;
                }
            }
        }
        private static int Max(int[] array)
        {
            int max=array[0];
            for(int i =1; i<array.Length; i++)
            {
                if( array[i] > max )
                    max = array[i];
            }
            return max;
        }
        private static int Min(int[] array)
        {
            int min=array[0];
            for(int i =1; i<array.Length; i++)
            {
                if( array[i] < min )
                    min = array[i];
            }
            return min;
        }
        private static int abs(int a)
        {
            if(a>0) return a;

            return -a;
        }
    }
}