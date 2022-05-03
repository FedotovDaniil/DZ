Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());
string ans = (numA % 2 == 0) ? $"{numA} четное число" : $"{numA} не четное число";
Console.WriteLine(ans);