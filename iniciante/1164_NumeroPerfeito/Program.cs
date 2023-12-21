int testes = Convert.ToInt32(Console.ReadLine());
int soma = 0;
for (int i = 1; i <= testes; i++)
{
    int ehPerfeito = Convert.ToInt32(Console.ReadLine());

    for (int j = ehPerfeito - 1; j >= 1; j--)
    {
        if (ehPerfeito % j == 0)
        {
            soma += j;
        }
    }

    if (soma == ehPerfeito)
    {
        Console.WriteLine($"{ehPerfeito} eh perfeito");
    }
    else
    {
        Console.WriteLine($"{ehPerfeito} nao eh perfeito");
    }

    soma = 0;
}