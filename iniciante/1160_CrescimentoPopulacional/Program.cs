int casosDeTestes = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= casosDeTestes; i++)
{
    string[] valores = Console.ReadLine().Split();
    int populacaoA = Convert.ToInt32(valores[0]);
    int populacaoB = Convert.ToInt32(valores[1]);

    decimal percentualCrescimentoA = Convert.ToDecimal(valores[2]);
    decimal percentualCrescimentoB = Convert.ToDecimal(valores[3]);

    int somaAnos = 0;

    while (populacaoA <= populacaoB)
    {
        decimal crescimentoA = populacaoA * (percentualCrescimentoA / 100);
        populacaoA += (int)crescimentoA;

        decimal crescimentoB = populacaoB * (percentualCrescimentoB / 100);
        populacaoB += (int)crescimentoB;

        somaAnos++;

        if (somaAnos > 100)
        {
            break;
        }
    }

    if (somaAnos <= 100)
    {
        Console.WriteLine($"{somaAnos} anos.");
    }
    else
    {
        Console.WriteLine("Mais de 1 seculo.");
    }
}

