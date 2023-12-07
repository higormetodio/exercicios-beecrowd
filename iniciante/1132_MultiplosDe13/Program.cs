int numeroX = Convert.ToInt32(Console.ReadLine());
int numeroY = Convert.ToInt32(Console.ReadLine());
int somaNaoMultiplos = 0;

if (numeroX > numeroY)
{
    int maior = numeroX;
    numeroX = numeroY;
    numeroY = maior;
}

for (int i = numeroX; i <= numeroY; i++)
{
    if (i % 13 != 0)
    {
        somaNaoMultiplos += i;
    }
}

Console.WriteLine(somaNaoMultiplos);