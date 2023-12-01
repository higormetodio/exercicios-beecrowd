// Ler o número N de casos a serem testados
// inicializar um totalizador com zero
// percorrer até que o número de testes seja satisfeito
// Ler dois números na mesma linha
// Verificar se o primeiro número é ou não maior do que o segundo número
// inverter os números em caso da condição anterior ser verdadeira
// percorrer os números exclusive
// verificar se o número percorrido na condição anterior é impar
// somar o número se a condição anterior for atendida

using System.Globalization;

int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int primeiroValor = Convert.ToInt32(valores[0]);
    int segundoValor = Convert.ToInt32(valores[1]);
    int soma = 0;

    if (primeiroValor > segundoValor)
    {
        int maior = primeiroValor;
        primeiroValor = segundoValor;
        segundoValor = maior;
    }

    for (int j = primeiroValor + 1; j < segundoValor; j++)
    {
        if (j % 2 != 0)
        {
            soma += j;
        }
    }
    Console.WriteLine(soma);
}


