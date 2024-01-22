int valorN = Convert.ToInt32(Console.ReadLine());
int[] vetorX = new int[valorN];
string[] valores = Console.ReadLine().Split(' ', valorN);

for (int i = 0; i < valorN; i++)
{
    vetorX[i] = Convert.ToInt32(valores[i]);
}

//Utilizando funções do System.Linq
//Console.WriteLine($"Menor valor: {vetorX.Min()}");
//Console.WriteLine($"Posicao: {Array.IndexOf(vetorX, vetorX.Min())}");
int menor = vetorX[0];
int atual;
int indice = 0;

for (int i = 1; i < valorN; i++)
{
    atual = vetorX[i];

    if (atual < menor)
    {
        menor = atual;
        indice = i;
    }
}

Console.WriteLine($"Menor valor: {menor}");
Console.WriteLine($"Posicao: {indice}");


