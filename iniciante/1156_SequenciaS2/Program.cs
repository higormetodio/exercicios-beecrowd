double valorS = 1;
int impar = 1;
int dobro = 2;

while (impar <= 39)
{
    impar += 2;
    valorS += (double)impar / dobro;
    dobro *= 2;
}

Console.WriteLine($"{valorS:F2}");
