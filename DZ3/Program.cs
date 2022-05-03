int numA = new Random().Next(0,20);
Console.WriteLine(numA);

/*while (count<numA)
{
    if (count%2==0)
    {
        Console.WriteLine(count); 
        count++;
    }
    else
    {
        count++;
    }
}*/
for (int count = 2; count<=numA;count+=2)
Console.WriteLine(count); 
