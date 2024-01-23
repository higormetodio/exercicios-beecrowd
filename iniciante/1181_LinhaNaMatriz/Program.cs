double[,] matriz = new double[12, 12];
int linha = Convert.ToInt32(Console.ReadLine());
char opcao = Convert.ToChar(Console.ReadLine().ToUpper());
double soma = 0.0;

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());

        if (i == linha)
        {
            soma += matriz[linha, j];
        }
    }
}

if (opcao == 'S')
{
    Console.WriteLine($"{soma:F1}");
}
else if (opcao == 'M')
{
    Console.WriteLine($"{soma / 12:F1}");
}
