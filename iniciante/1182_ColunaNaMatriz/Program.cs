int coluna = Convert.ToInt32(Console.ReadLine());
char letra = Convert.ToChar(Console.ReadLine().ToUpper());
double[,] matriz = new double[12, 12];
double soma = 0.0;

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());

        if (j == coluna)
        {
            soma += matriz[i, j];
        }
    }
}

if (letra == 'S')
{
    Console.WriteLine($"{soma:F1}");
}
else if (letra == 'M')
{
    double media = soma / 12;
    Console.WriteLine($"{media:F1}");
}