double soma = 0;
int contador = 1;

while (contador <= 3)
{
    string valores = Console.ReadLine();

    if (valores == "caw caw")
    {
        Console.WriteLine(Convert.ToInt32(soma));
        soma = 0;
        contador++;
    }

    for (int i = 0; i < 3; i++)
    {
        if (valores[i] == '*')
            soma += Math.Pow(2, 2 - i);
    }
}


