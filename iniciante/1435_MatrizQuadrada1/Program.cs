int valor = Convert.ToInt32(Console.ReadLine());
int[,] matriz = new int[valor, valor];
int distanciaLinha = 0;
int distanciaColuna = 0;

while (valor != 0)
{
    for (int i = 0; i < valor; i++)
    {
        for (int j = 0; j < valor; j++)
        {
            if (i < valor - i - 1)
            {
                distanciaLinha = i;
            }
            else
            {
                distanciaLinha = valor - i - 1;
            }

            if (j < valor - j - 1)
            {
                distanciaColuna = j;
            }
            else
            {
                distanciaColuna = valor - j - 1;
            }

            if (distanciaLinha < distanciaColuna)
            {
                matriz[i, j] = distanciaLinha + 1;
            }
            else
            {
                matriz[i, j] = distanciaColuna + 1;
            }
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



