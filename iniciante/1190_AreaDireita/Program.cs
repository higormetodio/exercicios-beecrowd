char letra = Convert.ToChar(Console.ReadLine().ToUpper());
double[,] matriz = new double[12, 12];
int limite = matriz.GetLength(0);
int diagonal = limite - 1;
double soma = 0.0;
int contador = 0;

for (int i = 0; i < limite; i++)
{
    for (int j = 0; j < limite; j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());

        if (j > diagonal && j > i)
        {
            soma += matriz[i, j];
            contador++;
        }
    }
    diagonal--;
}

if (letra == 'S')
{
    Console.WriteLine($"{soma:F1}");
}
else if (letra == 'M')
{
    Console.WriteLine($"{soma / contador:F1}");
}
