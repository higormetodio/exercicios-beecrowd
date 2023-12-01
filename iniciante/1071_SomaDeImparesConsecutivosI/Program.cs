int primeiroValor = Convert.ToInt32(Console.ReadLine());
int segundoValor = Convert.ToInt32(Console.ReadLine());
int maior;

int soma = 0;

//Verificando o menor e o maior número;
if (primeiroValor > segundoValor)
{
    maior = primeiroValor;
    primeiroValor = segundoValor;
    segundoValor = maior;
}

//Loop para verificar os valores entre o menor (exclusive) e o maior (exclusive)
for (int i = primeiroValor + 1; i < segundoValor; i++)
{
    //soma dos valores ímpares
    if (i % 2 != 0)
        soma += i;
}

Console.WriteLine(soma);

