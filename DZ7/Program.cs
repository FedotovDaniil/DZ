string num = Convert.ToString(new Random().Next(10000, 100000));
Console.WriteLine(num);

bool pol = true;
for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - i-1]) 
    {
        pol = false;
        break;
    }
}
if (pol)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}



