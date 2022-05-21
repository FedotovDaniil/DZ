//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8

using dzAndMore;


Console.Clear();
int rows = 5;
int columns = 6;
int min = 10;
int max = 100;

int[,] array = MyMetods.GetArray(rows, columns, min, max);

int[,] array2 = MyMetods.GetArray(rows, columns, min, max);

int[,] array3 = Multiplication(array, array2, rows, columns);

int[,,] array4 = GetTreeArray();

int[,] array5 = Ulitka(rows);


MyMetods.PrintArray(array);
Console.WriteLine();
Console.WriteLine(" Задача 54");
Console.WriteLine();
MyMetods.PrintArray(Sort(array));
Console.WriteLine();
Console.WriteLine(" Задача 56");
Console.WriteLine();
MyMetods.PrintArray(array);
Console.WriteLine($" Строка {GetSum(array)} имеет минимальную сумму");
Console.WriteLine();
Console.WriteLine(" Задача 58");
Console.WriteLine();
MyMetods.PrintArray(array);
Console.WriteLine();
MyMetods.PrintArray(array2);
Console.WriteLine();
MyMetods.PrintArray(array3);
Console.WriteLine();
Console.WriteLine(" Задача 60");
Console.WriteLine();
MyMetods.PrintTreeArray(array4);
Console.WriteLine();
Console.WriteLine(" Задача 62");
Console.WriteLine();
MyMetods.PrintArray(array5);

int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) / 2; j++)
        {
            int min = j;
            int max = j;
            for (int k = j; k < array.GetLength(1) - j; k++)
            {
                if (array[i, min] > array[i, k])
                    min = k;
                if (array[i, max] < array[i, k])
                    max = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, min];
            array[i, min] = temp;
            if (j == max)
                max = min;
            temp = array[i, array.GetLength(1) - j - 1];
            array[i, array.GetLength(1) - j - 1] = array[i, max];
            array[i, max] = temp;
        }
    }
    return array;
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetSum(int[,] array)
{
    int k = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
            minSum = sum;
        else
        if (sum < minSum)
        {
            minSum = sum;
            k = i;
        }
    }
    return k;
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//и

//1 5 8 5

//4 9 4 2

//7 2 2 6

//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10

//20 81 8 6

//56 8 4 24

//10 6 24 49

int[,] Multiplication(int[,] array, int[,] array2, int rows, int columns)
{
    int[,] array3 = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array3[i, j] = array[i, j] * array2[i, j];
        }
    }
    return array3;
}

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу,которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2

//12(0,0,0) 22(0, 0, 1)

//45(1, 0, 0) 53(1, 0, 1)

int[,,] GetTreeArray(int rows = 2, int columns = 2, int polochki = 2)
{
    int[,,] result = new int[rows, columns, polochki];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < polochki; k++)
            {

                result[i, j, k] = i * 100 + j * 10 + k;

            }
        }
    }
    return result;
}

//Задача 62.Заполните спирально массив.

//Например, на выходе получается вот такой массив:

//1 2 3 4

//12 13 14 5

//11 16 15 6

//10 9 8 7

int[,] Ulitka(int rows)
{
    int[,] mas = new int[rows, rows];
    int k = 1;
    int temp = 0;
    int i, j = 0;
    int n1 = rows;
    while (k <= n1 * n1)
    {
        for (i = temp; i < rows; i++) 
            mas[j, i] = k++;
        j = i - 1;
        for (i = temp + 1; i < rows; i++)
            mas[i, j] = k++;
        for (i = rows - 2; i >= temp; i--)
            mas[j, i] = k++;
        j = temp;
        for (i = rows - 2; i > temp; i--)
            mas[i, j] = k++;
        rows--;
        temp++;
        j = temp;
    }
    return mas;
}


