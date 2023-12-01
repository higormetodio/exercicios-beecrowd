// Digitar dois números inteiros
// Verificar se o primeiro número é maior que o segundo
// Inverter os números caso a condição anterior seja satisfeita
// Repetir a sequeência abaixo até que um dos números digitados seja > 0 (zero)
// Passar entre o primeiro número digitado até o segundo número digitado
// imprimir esses números na mesma linha
// aplicar a soma de cada um dos números
// imprimir a soma quato todos números foram somados
// Digitar dois números inteiros

string[] valores = Console.ReadLine().Split(' ');
int primeiroValor = Convert.ToInt32(valores[0]);
int segundoValor = Convert.ToInt32(valores[1]);

while (primeiroValor > 0 && segundoValor > 0)
{
    int soma = 0;
    if (primeiroValor > segundoValor)
    {
        int maior = primeiroValor;
        primeiroValor = segundoValor;
        segundoValor = maior;
    }


    for (int i = primeiroValor; i <= segundoValor; i++)
    {
        Console.Write($"{i} ");
        soma += i;
    }
    Console.WriteLine($"Sum={soma}");

    valores = Console.ReadLine().Split(' ');
    primeiroValor = Convert.ToInt32(valores[0]);
    segundoValor = Convert.ToInt32(valores[1]);
}