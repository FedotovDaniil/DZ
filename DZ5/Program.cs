int numA = new Random().Next(1, 10000);
Console.WriteLine(numA);

string numB = numA.ToString();
if (numA > 99)
{
    Console.WriteLine(numB[2]);
}
else
{
    Console.WriteLine($"у числа {numA} нет третьего числа");
}