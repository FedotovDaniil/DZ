//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
GetArray();

void GetArray()
{
    Random rand = new Random();
    int[] A = new int[8];
    for (int i = 0; i< A.Length; i++)
        A[i] = rand.Next();
    Console.WriteLine(String.Join(", ", A));
}