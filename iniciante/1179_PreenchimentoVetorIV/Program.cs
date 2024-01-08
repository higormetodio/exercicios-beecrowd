List<int> vetorPar = new List<int>();
List<int> vetorImpar = new List<int>();
int contador = 0;

while (contador < 15)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    contador++;

    if (numero % 2 == 0)
    {
        vetorPar.Add(numero);
    }
    else
    {
        vetorImpar.Add(numero);
    }

    if (vetorPar.Count == 5)
    {
        for (int i = 0; i < vetorPar.Count; i++)
        {
            Console.WriteLine($"par[{i}] = {vetorPar[i]}");
        }
        vetorPar.Clear();
    }

    if (vetorImpar.Count == 5)
    {
        for (int i = 0; i < vetorImpar.Count; i++)
        {
            Console.WriteLine($"impar[{i}] = {vetorImpar[i]}");
        }
        vetorImpar.Clear();
    }
}


for (int i = 0; i < vetorImpar.Count; i++)
{
    Console.WriteLine($"impar[{i}] = {vetorImpar[i]}");
}

for (int i = 0; i < vetorPar.Count; i++)
{
    Console.WriteLine($"par[{i}] = {vetorPar[i]}");
}