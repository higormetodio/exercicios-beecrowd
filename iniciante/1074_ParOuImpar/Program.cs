int numero = Convert.ToInt32(Console.ReadLine());
int[] valoresX = new int[numero];

if (numero < 10000)
{
    for (int i = 0; i < numero; i++)
    {
        int valor = Convert.ToInt32(Console.ReadLine());

        if (valor > Math.Pow(-10, 7) && valor < Math.Pow(10, 7))
        {
            valoresX[i] = valor;
        }
    }

    foreach (int valorX in valoresX)
    {
        if (valorX < 0 && valorX % 2 == 0)
        {
            Console.WriteLine("EVEN NEGATIVE");
        }
        else if (valorX < 0 && valorX % 2 != 0)
        {
            Console.WriteLine("ODD NEGATIVE");
        }
        else if (valorX > 0 && valorX % 2 == 0)
        {
            Console.WriteLine("EVEN POSITIVE");
        }
        else if (valorX > 0 && valorX % 2 != 0)
        {
            Console.WriteLine("ODD POSITIVE");
        }
        else
        {
            Console.WriteLine("NULL");
        }
    }
}
