using System;
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task34();
            // Task36();
            // Task38();
        }

        static void Task34()
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
            int[] arr = new int[10];
            int kolvoChet = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write(arr[i] + " ");
                if (arr[i] % 2 == 0)
                {
                    kolvoChet++;
                }

            }
            Console.WriteLine("Колво четных - " + kolvoChet);
        }
        static void Task36()
        {
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.
            //Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //Вариант 1, где номер элемента начинается с 0
            //int[] arr = new int[10];
            //int summaElementov = 0;
            //Random rnd = new Random();
            //for( int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(1, 100);
            //    Console.Write(arr[i] + " ");
            //    if(i % 2 != 0)
            //    {
            //        summaElementov += arr[i];
            //    }
            //}
            //Console.WriteLine("сумма элементов на нечетных позициях - " + summaElementov);
            //Вариант 2, где номер элемента считается с 1, для удобства пользователя
            int[] arr = new int[10];
            int summaElementov = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length; i = i + 2)
            {
                summaElementov += arr[i];
            }
            Console.WriteLine("сумма элементов на нечетных позициях - " + summaElementov);

        }

        static void Task38()
        {
            //Задача 38: Задайте массив вещественных чисел. 
            //Найдите разницу между максимальным и минимальным элементов массива.
            //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
            double[] arr = new double[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round((rnd.Next(-10, 10) + rnd.NextDouble()), 3);
                Console.Write(arr[i] + " ");
            }
            double max = arr.Max();
            double min = arr.Min();
            double difference = max - min;
            Console.WriteLine($"\nmax = {max}\nmin = {min}\nразница = {difference}");
        }
    }
}
