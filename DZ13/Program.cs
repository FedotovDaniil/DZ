/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

using System;
using System.Linq;

Console.WriteLine("Введите числа");
int[] ar1=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
Console.WriteLine(ar1);
int count = 0;

for (int i = 0; i < ar1.Length; i++)
{
    if (ar1[i] > 0) count++;  
}
Console.WriteLine(count);