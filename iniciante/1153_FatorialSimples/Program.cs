int numero = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;
for (int i = numero; i >= 1; i--)
{
    fatorial *= i;
}

Console.WriteLine(fatorial);