using System;
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task25();
            //Task27();
            Task29();
        }

        static void Task25()
        {
            // Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число
            // A в натуральную степень B.
            // 3, 5-> 243(3⁵)
            // 2, 4-> 16
            try
            {
                int a = 0, b = 0, c = 1;
                Console.WriteLine("введите а");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("введите б ");
                b = int.Parse(Console.ReadLine());
                if (b > 0)
                {
                    for (int i = 1; i <= b; i++)
                    {
                        c = a * c;
                    }
                    Console.WriteLine("результат: " + c);
                }
                else if (b == 0)
                {
                    Console.WriteLine("результат: 1 ");
                }
                else
                {
                    Console.WriteLine("введите положительное число");

                }
            }catch{
                Console.WriteLine("вводите числовые значения");
                Environment.Exit(0);
            }
        }

        static void Task27()
        {
            //Задача 27: Напишите программу, которая принимает на вход число и 
            //выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            try
            {
                int a = 0, c = 0;
                Console.WriteLine("введите а");
                a = int.Parse(Console.ReadLine());
                if (a > 0)
                {
                    while (a > 0)
                    {
                        c = c + a % 10;
                        a = a / 10;
                    }
                    Console.WriteLine("res " + c);
                }
                else if (a < 0) { Console.WriteLine("введите положительное число"); }
                else if (a == 0) { Console.WriteLine("res 0" ); }
                
            }catch {
                Console.WriteLine("вводите целочисленные значения");
                Environment.Exit(1);
            }
        }

        static void Task29()
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
            //6, 1, 33-> [6, 1, 33]
            int[] arr = new int[8];
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
