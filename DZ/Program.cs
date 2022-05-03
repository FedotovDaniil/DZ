Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
/*
if(numA>numB)
{
    Console.WriteLine($"Число {numA} больше чем число {numB}");
}
else
{
    Console.WriteLine($"Число {numB} больше чем число {numA}");
}*/
int answer = (numA > numB) ? numA : numB;
Console.WriteLine($"Максимальное число {answer}");