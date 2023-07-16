using System;
using System.Collections.Generic;
using System.Linq;
namespace SeminarTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа за 3 семинар

            //TaskNineteen();
            //TaskTwentyOne();
            //TaskTwentyThree();

        }

        //Задача 19: Напишите программу, которая принимает на
        //вход пятизначное число и проверяет, является ли оно
        //палиндромом.
        //14212->нет
        //23432->да
        //12821->да
        static void TaskNineteen()
        {
            int a = 0;
            Console.WriteLine("введите пятизначное число");
            a = int.Parse(Console.ReadLine());

            if (a >= 10000 && a <= 99999)
            {
                string str = a.ToString();
                int[] b = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    b[i] = int.Parse(str[i].ToString());

                    Console.Write(b[i] + " ");
                }
                Console.WriteLine();
                int[] c = new int[b.Length];

                // for (int i = b.Length - 1; i >= 0; i--)
                for (int i = 0; i < b.Length; i++)

                {
                    c[i] = b[i];
                }

                Array.Reverse(c);
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i] + " ");
                }
                Console.WriteLine();
                bool isEqual = b.SequenceEqual(c);
                if (isEqual)
                {
                    Console.WriteLine("полиндром");
                }
                else { Console.WriteLine("не полиндром"); }

            }
            else { Console.WriteLine("нужно ввести пятизначное"); }
        }

        //Задача 21: Напишите программу, которая принимает на
        //вход координаты двух точек и находит расстояние между
        //ними в 3D пространстве.
        //A(3,6,8); B(2,1,-7), -> 15.84
        //A(7,-5, 0); B(1,-1,9) -> 11.53
        static void TaskTwentyOne()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, z1 = 0, z2 = 0;
            double d = 0;
            Console.WriteLine("введите x1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите x2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите y2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите z1");
            z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите z2");
            z2 = int.Parse(Console.ReadLine());

            d = Math.Sqrt((x2-x1) * (x2-x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            Console.WriteLine("d = " + d);

        }

        //Задача 23
        //Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
        //3 -> 1, 8, 27
        //5 -> 1, 8, 27, 64, 125
        static void TaskTwentyThree()
        {
            int n = 0;
            Console.WriteLine("введите n");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int c = i * i * i;
                    Console.Write(c + " ");
                }
            }
        }

    }




}

