//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество чисел в строке");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число");
int max = Convert.ToInt32(Console.ReadLine());

double[,] Array = GetArray(rows, columns, min, max);
PrintArray(Array);

double[,] GetArray(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble() + new Random().Next(min, max);
        }
    }
    return result;
}





void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}  ");
        }
        Console.WriteLine();
    }

}