namespace Algorithms
{
    public static partial class Sorter 
    {
        public static void BubbleSort( int[] array) 
        {
            
            int lastEl=array.Length-1;
            int temp =0;
            bool needsSwich;
            do
            {
                needsSwich=false;
                for(int i=0;i<lastEl;i++)
                {
                    if(array[i] > array[i+1])
                    {
                        temp=array[i];
                        array[i]=array[i+1];
                        array[i+1]=temp;

                        needsSwich=true;
                    }
                }
                lastEl--;
            }
            while (needsSwich);
        }
    }
}