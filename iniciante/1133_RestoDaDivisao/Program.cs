int valorX = Convert.ToInt32(Console.ReadLine());
int valorY = Convert.ToInt32(Console.ReadLine());

if (valorX > valorY)
{
    int maior = valorX;
    valorX = valorY;
    valorY = maior;
}

for (int i = valorX + 1; i < valorY; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}