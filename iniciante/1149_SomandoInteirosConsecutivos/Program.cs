string[] valores = Console.ReadLine().Split(' ');
int valorA = Convert.ToInt32(valores[0]);
int ultimoValor = valores.Length - 1;
int valorN = Convert.ToInt32(valores[ultimoValor]);
int soma = 0;

// while (valorN <= 0)
// {
//     valorN = Convert.ToInt32(Console.ReadLine());
// }


for (int i = 0; i < valorN; i++)
{
    soma += valorA + i;
}

Console.WriteLine(soma);