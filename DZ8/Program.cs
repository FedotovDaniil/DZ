
Console.WriteLine("Введите координаты");
string[] ar1 =  Console.ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int x1 = int.Parse(ar1[0]);
int y1 = int.Parse(ar1[1]);
int z1 = int.Parse(ar1[2]);
int x2 = int.Parse(ar1[3]);
int y2 = int.Parse(ar1[4]);
int z2 = int.Parse(ar1[5]);


double lenth = Math.Pow(x2-x1,2);
double high = Math.Pow(y2-y1,2);
double width = Math.Pow(z2-z1,2);
double sqrt = Math.Sqrt(lenth + high + width);

Console.WriteLine($"{sqrt:f2}");