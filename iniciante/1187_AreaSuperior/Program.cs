char letra = Convert.ToChar(Console.ReadLine().ToUpper());
double[,] matriz = new double[12, 12];
int limite = matriz.GetLength(0);
int controle = limite - 1;
int contador = 0;
double soma = 0;

for (int i = 0; i < limite; i++)
{
    for (int j = 0; j < limite; j++)
    {
        matriz[i, j] = Convert.ToDouble(Console.ReadLine());

        if (i + 1 <= j && j < controle)
        {
            soma += matriz[i, j];
            contador++;
        }
    }

    controle--;
}

if (letra == 'S')
{
    Console.WriteLine($"{soma:F1}");
}
else if (letra == 'M')
{
    Console.WriteLine($"{soma / contador:F1}");
}
