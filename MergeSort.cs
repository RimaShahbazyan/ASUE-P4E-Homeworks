
namespace Algorithms
{
    public static partial class Sorter 
    {
        public static void MergeSort(int[] array)
        {
            // b - beginning, e - end, m - middle m+1 is 1st el of second half , curr is current size of subarrays 
            int  curr=1, b=0, e,m;
            while (curr<array.Length)
            {
                b=0;
                e=curr*2-1+b;
                
                while (e!=array.Length-1)
                {
                    m=curr-1+b;
                    e=curr*2-1+b;
                    
                    if(e>array.Length-1)
                        e=array.Length-1;

                    Merge( array, b, e, m);
                    b+=curr*2;
                }
                curr=curr*2;
            }
        }
        private static void Merge(int[] array, int b, int e, int m)
        {
            int i1=b,i2=e, temp;
            while(i1<m+1)
            {
                while(i2>m)
                {
                    if(array[i1]>array[i2])
                    {
                        temp=array[i1];
                        array[i1]=array[i2];
                        array[i2]=temp;
                    }
                    i2--;
                }
                i1++;
                i2=e;
            }
        }
    }
}

// 
// 
// 
// ref must be init
// out accepts intitialized or not in...  parrametrs and get a reult
// 
// parse mi tipi arjeqy urish tipi arjeqi