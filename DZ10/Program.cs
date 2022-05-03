//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число которое хотите возвести в степень");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень в которое хотите возвести число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetPow(a, b));

int GetPow(int a, int b)
{
    int c = a;
    while(b > 1)
    {
        b--;
        c *= a;
    }
    return c;
}

