/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/
using System;
using System.Linq;

Console.WriteLine("Введите числа");
double[] ar1=Console.ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>double.Parse(x)).ToArray();

double b1 = ar1[0];
double k1 = ar1[1];
double b2 = ar1[2];
double k2 = ar1[3];

double X = (b2-b1) / (k1-k2);
double Y = k1*X + b1;
Console.WriteLine($"({X},{Y})");