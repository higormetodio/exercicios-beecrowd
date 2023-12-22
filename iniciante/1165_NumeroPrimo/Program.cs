int casosTestes = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= casosTestes; i++)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    bool ehPrimo = true;

    for (int j = 2; j <= Math.Sqrt(numero); j++)
    {
        if (numero <= 1 || numero % j == 0)
        {
            Console.WriteLine($"{numero} nao eh primo");
            ehPrimo = false;
            break;
        }
    }

    if (ehPrimo)
    {
        Console.WriteLine($"{numero} eh primo");
    }
}
