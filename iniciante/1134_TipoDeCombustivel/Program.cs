bool validacao = true;
(int alcool, int gasolina, int diesel) = (0, 0, 0);

while (validacao)
{
    int resposta = Convert.ToInt32(Console.ReadLine());

    switch (resposta)
    {
        case 1:
            alcool++;
            break;
        case 2:
            gasolina++;
            break;
        case 3:
            diesel++;
            break;
        case 4:
            validacao = false;
            break;
    }
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");