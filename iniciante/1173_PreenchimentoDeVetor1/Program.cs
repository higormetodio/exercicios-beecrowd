int[] vetorN = new int[10];
int valor = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    vetorN[i] = valor;
    valor *= 2;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"N[{i}] = {vetorN[i]}");
}

