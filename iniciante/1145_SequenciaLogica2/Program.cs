string[] valores = Console.ReadLine()!.Split(' ');
int valorX = Convert.ToInt32(valores[0]);
int valorY = Convert.ToInt32(valores[1]);
int contador = 1;

if (valorX > 1 && valorX < 20 && valorY > valorX && valorY < 100000)
{
    for (int i = 1; i <= valorY; i++)
    {
        if (contador < valorX)
        {
            Console.Write($"{i} ");
            contador++;
        }
        else
        {
            Console.WriteLine($"{i}");
            contador = 1;
        }
    }
}

