using System;

namespace twinPaired
{
    class Program
    {
        //1. An array is defined to be twin paired if its even-valued elements
        //(if any) are in ascending order and its odd-valued elements(if any) are 
        //in ascending order.
        // The array { -6, 12,1,24, 3,5} is a twin paired, { 3,2,1} is not twin paired.
        // write a function named isTwinpaired that returns 1 if its array argument is twin paired
        // otherwise returns 0;
        //other twin paired arrays include;
         //{ 2,4,32} 
         //{2,2,2,1,1,1}
         //{1,19,23}
         //{1,2}
         //{2,1}
         //{8}
         //{17}
         //{}
        
        static int istwinpaired(int[] a)
        {
            int prevEven = -10000;
            int preOdd = -11111;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (a[i] >= prevEven)
                    {
                        prevEven = a[i];
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (a[i] >= preOdd)
                    {
                        preOdd = a[i];
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        static void Main()
        {
            int[] a = { 3, 2, 1 };
            Console.WriteLine(istwinpaired(a));
        }
        
    }
}
