using dzAndMore;




using System;
using static System.Console;


Clear();
WriteLine("Введите число");
int m = int.Parse(ReadLine()!);
WriteLine("Введите число");
int n = int.Parse(ReadLine()!);

string result = GetNumbers(m, n);
WriteLine(result);
WriteLine();
int result2 = SumNumbers(m, n);
WriteLine(result2);
WriteLine();
int result3 = Akkerman(m, n);
WriteLine(result3);

string GetNumbers(int start, int end)
{
    int temp;
    if (start > end)
    {
        if (start == end) return start.ToString();
        return (start + " " + GetNumbers(start - 1, end));
    }
    else
    {
        temp = start;
        start = end;
        end = temp;
        if (start == end) return start.ToString();
        return (start + " " + GetNumbers(start - 1, end));
    }


}

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    if (end < start)
        return start + SumNumbers(--start, end);
    else
        return start + SumNumbers(++start, end);
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

m = 8;
Console.WriteLine("63 " + m);
Console.WriteLine("64 " + m--);
Console.WriteLine("65 " + m);
Console.WriteLine("66 " + --m);
Console.WriteLine("67 " + m);
Console.WriteLine("68 " + (m - 1));
Console.WriteLine("69 " + m);

