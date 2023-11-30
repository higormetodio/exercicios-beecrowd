// i = 0 / 0.2
// j = 1 / j = 2 / j = 3 /
// I=0 J=1
// I=0 J=2
// I=0 J=3
// I=0.2 J=1.2
// I=0.2 J=2.2
// I=0.2 J=3.2

//decimal soma = 0.8m + 0.2m;
// int divisao = (int)(soma % 2.0m);

// Console.WriteLine(soma);
// Console.WriteLine(divisao);

for (decimal i = 0; i <= 2; i += 0.2m)
{
    for (decimal j = 1; j <= 3; j++)
    {
        // Para tirar a precisão do Decimal quando precisamos que os resultados seja um número sem ponto flutuante
        if (i == 1 || i == 2)
        {
            Console.WriteLine($"I={i:F0} J={j + i:F0}");
        }
        else
        {
            Console.WriteLine($"I={i} J={j + i}");
        }
    }
}
