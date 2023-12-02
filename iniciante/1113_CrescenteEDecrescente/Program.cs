string[] valores = Console.ReadLine().Split(' ');
int primeiroValor = Convert.ToInt32(valores[0]);
int segundoValor = Convert.ToInt32(valores[1]);

while (primeiroValor != segundoValor)
{
    if (primeiroValor > segundoValor)
    {
        Console.WriteLine("Decrescente");
    }
    else
    {
        Console.WriteLine("Crescente");
    }

    valores = Console.ReadLine().Split(' ');
    primeiroValor = Convert.ToInt32(valores[0]);
    segundoValor = Convert.ToInt32(valores[1]);
}
