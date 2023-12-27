int[] vetorN = new int[20];

for (int i = vetorN.Length - 1; i >= 0; i--)
{
    vetorN[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < vetorN.Length; i++)
{
    Console.WriteLine($"N[{i}] = {vetorN[i]}");
}
