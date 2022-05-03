//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSumInNumber(a));


int GetSumInNumber(int a)
{
    int b = 0;
    while (a > 0)
    {
        b += a % 10;
        a /= 10;
    }
    return b;
}