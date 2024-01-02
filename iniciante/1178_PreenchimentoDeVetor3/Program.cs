decimal[] vetorN = new decimal[100];
decimal valorX = Convert.ToDecimal(Console.ReadLine());
vetorN[0] = valorX;

for (int i = 1; i < vetorN.Length; i++)
{
    vetorN[i] = vetorN[i - 1] / 2;
}

for (int i = 0; i < vetorN.Length; i++)
{
    Console.WriteLine($"N[{i}] = {decimal.Round(vetorN[i], 4, MidpointRounding.ToEven)}");
}