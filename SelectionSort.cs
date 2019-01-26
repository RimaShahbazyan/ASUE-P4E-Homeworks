namespace Algorithms
{
    public partial class Sorter 
    {
        public static void SelectionSort(int[] array)
        {
            int temp, min;
            for(int i=0;i < array.Length;i++)
            {
                min=MinIndex(array,i);
                temp=array[min];
                array[min]=array[i];
                array[i]=temp;
            }
        }
        private static int MinIndex( int[] array,int i)
        {
            int min=array[i];
            int minIndex=i;
            for(; i<array.Length; i++)
            {
                if(min>array[i])
                {
                    min=array[i];
                    minIndex=i;
                }
            }
            return minIndex;
        }
    }
}
