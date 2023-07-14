using System;
namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 19, 3, 31, 5, 6, 6, 10, 14 };
            PrintArray(array); 
            SelectionSort(array);
            PrintArray(array);
            
        }

         static void PrintArray(int[] arr)
        {
            int lenght = arr.Length;
            for(int i = 0; i < lenght; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temporary = arr[i];
                arr[i] = arr[min];
                arr[min] = temporary;
            }
        }


    }
}
