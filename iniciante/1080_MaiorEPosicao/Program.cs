int[] valores = new int[100];
int numero;

for (int i = 0; i < 100; i++)
{
    numero = Convert.ToInt32(Console.ReadLine());
    valores[i] = numero;
}

int maior = valores[0];
int posicao = 0;

// foreach (int valor in valores)
// {
//     if (valor > maior)
//     {
//         maior = valor;
//         posicao = Array.IndexOf(valores, valor);
//     }
// }

for (int j = 0; j < valores.Length; j++)
{
    if (valores[j] > maior)
    {
        maior = valores[j];
        posicao = j + 1;
    }
}

Console.WriteLine(maior);
Console.WriteLine(posicao);
