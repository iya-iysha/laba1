﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] koef)
        {
            Console.Title = "Ваксина Ия ИУ5-33Б";
            double a = 0, b = 0, c = 0;
            if (koef.Length == 3)
            {
                double.TryParse(koef[0], out a);
                double.TryParse(koef[1], out b);
                double.TryParse(koef[2], out c);
            }
            else
            {
                Console.WriteLine("Введите значения коэффициентов биквадратного уравнения (ax^4 + bx^2 + c = 0):");
                bool result = false;
                while (result == false)
                {
                    Console.Write("a = ");
                    result = double.TryParse(Console.ReadLine(), out a);
                    if (result == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод коэффициента а! Попробуйте еще раз!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                result = false;
                while (result == false)
                {
                    Console.Write("b = ");
                    result = double.TryParse(Console.ReadLine(), out b);
                    if (result == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод коэффициента b! Попробуйте еще раз!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                result = false;
                while (result == false)
                {
                    Console.Write("c = ");
                    result = double.TryParse(Console.ReadLine(), out c);
                    if (result == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод коэффициента c! Попробуйте еще раз!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
            double x1, x2, x3, x4;
            if (a == 0 && b == 0)
            {
                if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Бесконечное количество решений, корни - любые числа.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет!");
                }
                Console.ReadKey(); //дальше код не выполняется
            }
            if (a == 0)
            {
                if (b != 0)
                {
                    if (c / b > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                    }
                    else
                    {
                        x1 = Math.Sqrt(-c / b);
                        x2 = (-1) * x1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: {0}, {1}.", x1, x2);
                    }
                }
            }
            else
            if (b == 0)
            {
                double k; //дополнительная переменная для хранения квадратного корня 
                if (c / a > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет!");
                }
                else
                {
                    k = Math.Sqrt(-c / a);
                    x1 = Math.Sqrt(k);
                    x2 = (-1) * x1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: {0}, {1}.", x1, x2);
                }
            }
            else
            {
                double D, D1, D2, D3;
                D = b * b - 4 * a * c;
                if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет!");
                }
                else
                {
                    D1 = Math.Sqrt(D); //корень из дискриминанта 
                    D2 = (-b + D1) / (2 * a); //выражение для х^2 
                    if (D2 > 0)
                    {
                        x1 = Math.Sqrt(D2);
                        x2 = (-1) * x1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: {0}, {1}", x1, x2);
                        D3 = (-b - D1) / (2 * a);
                        if (D3 > 0)
                        {
                            x3 = Math.Sqrt(D3);
                            x4 = (-1) * x3;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0}, {1}.", x3, x4);
                        }
                        else Console.Write(".");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет!");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}