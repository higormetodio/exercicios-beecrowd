char letra = Convert.ToChar(Console.ReadLine().ToUpper());
double[,] matriz = new double[12, 12];
int limite = matriz.GetLength(0);
int diagonal1 = 0;
int diagonal2 = limite - 1;
double soma = 0.0;
int contador = 0;

for (int i = 0; i < limite; i++)
{
    for (int j = 0; j < limite; j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());

        if (j > diagonal2 && j < diagonal1)
        {
            soma += matriz[i, j];
            contador++;
        }
    }
    diagonal1++;
    diagonal2--;
}

if (letra == 'S')
{
    Console.WriteLine($"{soma:F1}");
}

if (letra == 'M')
{
    Console.WriteLine($"{soma / contador:F1}");
}