(int contadorInter, int contadorGremio, int empate, int grenais) = (0, 0, 0, 0);
bool repetir = true;
int resposta = 1;

while (repetir)
{
    if (resposta == 1)
    {
        string[] placar = Console.ReadLine().Split(' ');
        int internacional = Convert.ToInt32(placar[0]);
        int gremio = Convert.ToInt32(placar[1]);

        if (internacional > gremio)
        {
            contadorInter++;
        }
        else if (gremio > internacional)
        {
            contadorGremio++;
        }
        else
        {
            empate++;
        }
        grenais++;
    }

    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    resposta = Convert.ToInt32(Console.ReadLine());

    if (resposta == 2)
    {
        repetir = false;
    }
}

Console.WriteLine($"{grenais} grenais");
Console.WriteLine($"Inter:{contadorInter}");
Console.WriteLine($"Gremio:{contadorGremio}");
Console.WriteLine($"Empates:{empate}");

if (contadorInter > contadorGremio)
{
    Console.WriteLine("Inter venceu mais");
}
else if (contadorGremio > contadorInter)
{
    Console.WriteLine("Gremio venceu mais");
}
