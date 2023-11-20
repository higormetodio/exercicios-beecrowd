int primeiroValor = Convert.ToInt32(Console.ReadLine());
int segundoValor = Convert.ToInt32(Console.ReadLine());
int menorValor;
int maiorValor;
int soma = 0;

//Verificando o menor e o maior número;
if (primeiroValor < segundoValor)
{
    menorValor = primeiroValor;
    maiorValor = segundoValor;
}
else
{
    menorValor = segundoValor;
    maiorValor = primeiroValor;
}

//Loop para verificar os valores entre o menor (exclusive) e o maior (exclusive)
for (int i = menorValor + 1; i < maiorValor; i++)
{
    //soma dos valores ímpares
    if (i % 2 != 0)
        soma += i;
}

Console.WriteLine(soma);

