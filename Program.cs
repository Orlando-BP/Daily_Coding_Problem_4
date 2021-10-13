using System;

namespace Daily_Coding_Problem_4
{
    class Program
    {
        /*Given an array of integers, 
         * find the first missing positive integer in linear time and constant space. 
         * In other words, find the lowest positive integer that does not exist in the array. 
         * The array can contain duplicates and negative numbers as well.
         */
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 4, -1, 1 };
            Console.WriteLine(Function(array));
        }
        static int Function(int[] array)
        {
            int min = array[0];
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            for (int i = min+1; i < max; i++)
            {
                bool flag = false;
                if(i > 1)
                { 
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (i == array[j])
                            flag = true;
                    }
                    if (flag == false)
                        return i;
                }
            }
            if (min > 1)
                return min - 1;
            else
                return max + 1;
        }
    }
}
