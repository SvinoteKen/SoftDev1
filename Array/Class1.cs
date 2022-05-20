using System;

namespace Array
{
    public class ArrayProcesor
    {
        static void RemoveAt(ref int[] array, int index) 
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++) 
            {
                newArray[i] = array[i];
            }
            for (int i = index+1; i < array.Length; i++)
            {
                newArray[i-1] = array[i];
            }

            array = newArray;
        }
        public int[] SortAndFilter(int[] a) 
        {
            int[] array=a;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < 0)
                    {
                        if (array[i] == array[j]) 
                        {
                            RemoveAt(ref array, i);
                        }
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array; 
        }
    }
}
