// Beecrowd - Problema 1827 - Matriz Quadrada IV
// https://judge.beecrowd.com/pt/problems/view/1827

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int tamanho))
        break;

    int[,] matriz = new int[tamanho, tamanho];
    int diagonal = tamanho - 1;
    int distancia = tamanho / 3;
    int centro = tamanho / 2;

    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            if (i == centro && j == centro)
            {
                matriz[i, j] = 4;
            }
            else if (i >= distancia && i <= tamanho - distancia - 1 && j >= distancia && j <= tamanho - distancia - 1)
            {
                matriz[i, j] = 1;
            }
            else if (i == j)
            {
                matriz[i, j] = 2;
            }
            else if (j == diagonal)
            {
                matriz[i, j] = 3;
            }
            else
            {
                matriz[i, j] = 0;
            }
            Console.Write(matriz[i, j]);
        }
        diagonal--;
        Console.WriteLine();
    }
    Console.WriteLine();
}