/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

Console.Clear();
int rows = Convert.ToInt32(new Random().Next(5,10));
int columns = Convert.ToInt32(new Random().Next(5,10));
int min = 10;
int max = 100;

int[,] Array = GetArray(rows, columns, min, max);
PrintArray(Array);

Console.WriteLine("Введите число для поиска");
int find = Convert.ToInt32(Console.ReadLine());

FindElementArray(Array, find);

void FindElementArray(int[,] Array, int find)
{
    Console.Clear();
    bool element = false;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(Array[i, j] == find)
            {
                element=true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{Array[i,j]} ");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{Array[i,j]} ");
            }
        }
        if(i!=rows - 1){Console.WriteLine();}
    }
    Console.WriteLine(element?"":$"Числа {find} нет в массиве");
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}