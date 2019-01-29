namespace Algorithms
{
    public static partial class Sorter 
    {
        public static void InsertationSort(int[] array)
        {
            int insert=array[1];
            int lastindex=0;
            int temp =0;
            do
            {
                for(int i=lastindex;i>-1;i--)
                {
                    if(array[i] > insert)
                    {
                        temp=array[i];
                        array[i]=array[i+1];
                        array[i+1]=temp;
                    }
                    else break;
                }
                lastindex++;
                if(lastindex!=array.Length-1)
                {
                    insert=array[lastindex+1];
                }
            }
            while (lastindex<array.Length-1);
        }
    }
}
