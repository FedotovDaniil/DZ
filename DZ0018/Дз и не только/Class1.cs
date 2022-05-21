using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzAndMore
{
    public static class MyMetods
    {
       public static int[,] GetArray(int rows, int columns, int min=0, int max=100)
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
       public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,5}", array[i, j] );
                }
                Console.WriteLine();
            }
        }
    
       public static void PrintTreeArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                    Console.Write("{0,4}", array[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
       }
    }      
}

