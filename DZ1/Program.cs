Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numС = Convert.ToInt32(Console.ReadLine());

int answer = ((numA > numB) && (numA > numС)) ? numA : ((numB > numA) && (numB > numС)) ? numB : numС;
Console.WriteLine($"Максимальное число {answer}");
