int valorX = valorX = Convert.ToInt32(Console.ReadLine());

while (valorX != 0)
{
    int ehPar = 0;
    int soma = 0;

    while (ehPar < 5)
    {
        if (valorX % 2 == 0)
        {
            soma += valorX;
            valorX++;
            ehPar++;
        }
        else
        {
            valorX++;
        }
    }

    Console.WriteLine(soma);

    valorX = Convert.ToInt32(Console.ReadLine());
}
