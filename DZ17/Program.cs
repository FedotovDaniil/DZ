Console.Clear();
int rows = Convert.ToInt32(new Random().Next(5,10));
int columns = Convert.ToInt32(new Random().Next(5,10));
int min = 10;
int max = 100;

int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
Average(array);

void Average(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < columns; i++)
    {
        double average = 0;
        for (int j = 0; j < rows; j++)
        {
            average += array[j, i];
            
        }
        average /= columns;
        if(Convert.ToInt32(average) == average)
        {
            
            Console.Write($"{Convert.ToInt32(average)} ");
        }
        else
        {
            Console.Write($"{average:f2} ");
        }
    }
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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}