for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("");

for (int i = 2;i < 20; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

for (int i = 2; i < 20; i++)
{
    if (i % 2 == 0) Console.Write(i + " ");
}
Console.WriteLine("\n");

int sum = 0;
for (int i = 51; i < 150; i++)
{
    sum += i;
}
Console.WriteLine(sum + "\n");

int evenSum = 0;
int oddSum = 0;

for (int i = 2; i < 120; i++)
{
    if (i % 2 == 0) evenSum+=i;
    else oddSum+=i;
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: "+ evenSum + "\n" + "1 ile 120 arasındaki tek sayıların toplamı: " + oddSum);
