/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
int numA = new Random().Next(1, 8);
Console.WriteLine(numA);

/*if (numA > 5)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}*/
string ans = (numA > 5) ? "да, выходной" : "нет, вали на работу";
Console.WriteLine(ans);
