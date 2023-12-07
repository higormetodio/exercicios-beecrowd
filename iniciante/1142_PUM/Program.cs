int numeroLinhas = Convert.ToInt32(Console.ReadLine());
int contador = 1;
int valorInicial = 1;

while (contador <= numeroLinhas)
{
    for (int i = valorInicial; i <= valorInicial + 2; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("PUM");

    valorInicial += 4;
    contador++;
}

