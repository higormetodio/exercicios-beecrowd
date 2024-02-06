int valor = Convert.ToInt32(Console.ReadLine());
int[,] matriz = new int[valor, valor];

while (valor != 0)
{
    for (int i = 0; i < valor; i++)
    {
        for (int j = 0; j < valor; j++)
        {
            matriz[i, j] = Math.Abs(i - j) + 1;
        }
    }

    for (int i = 0; i < valor; i++)
    {
        for (int j = 0; j < valor; j++)
        {
            Console.Write(matriz[i, j].ToString().PadLeft(3));

            if (j < valor - 1)
                Console.Write(" ");
            else
                Console.WriteLine();
        }
    }
    Console.WriteLine();
    valor = Convert.ToInt32(Console.ReadLine());
    matriz = new int[valor, valor];
}


