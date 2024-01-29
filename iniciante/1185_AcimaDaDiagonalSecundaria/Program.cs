char letra = Convert.ToChar(Console.ReadLine().ToUpper());
double[,] matriz = new double[12, 12];
double soma = 0.0;
int limite = matriz.GetLength(0) - 1;
int contador = 0;

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());
    }
}

for (int i = 0; i < limite; i++)
{
    for (int j = 0; j < limite - i; j++)
    {
        soma += matriz[i, j];
        contador++;
    }
}

if (letra == 'S')
{
    Console.WriteLine($"{soma:F1}");
}
else if (letra == 'M')
{
    Console.WriteLine($"{soma / contador:F1}");
}