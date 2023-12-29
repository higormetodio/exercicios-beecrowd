int[] vetor = new int[1000];
int valor = Convert.ToInt32(Console.ReadLine());
int contador = 0;


while (contador < vetor.Length)
{
    for (int i = 0; i < valor; i++)
    {
        if (contador < vetor.Length)
        {
            vetor[contador] = i;
            contador++;
        }
    }
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"N[{i}] = {vetor[i]}");
}


