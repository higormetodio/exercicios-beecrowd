int qtdExperiencia = Convert.ToInt32(Console.ReadLine());
int total = 0;
(int tipoR, int tipoS, int tipoC) = (0, 0, 0);
double percentualR, percentualS, percentualC;

for (int i = 1; i <= qtdExperiencia; i++)
{
    string[] resultado = Console.ReadLine().Split(' ');

    if (Convert.ToInt32(resultado[0]) >= 1 && Convert.ToInt32(resultado[0]) <= 15)
    {
        total += Convert.ToInt32(resultado[0]);

        if (resultado[1].ToUpper() == "R")
        {
            tipoR += Convert.ToInt32(resultado[0]);
        }
        else if (resultado[1].ToUpper() == "S")
        {
            tipoS += Convert.ToInt32(resultado[0]);
        }
        else if (resultado[1].ToUpper() == "C")
        {
            tipoC += Convert.ToInt32(resultado[0]);
        }
    }


}

percentualC = tipoC / (double)total;
percentualR = tipoR / (double)total;
percentualS = tipoS / (double)total;

Console.WriteLine($"Total: {total} cobaias");
Console.WriteLine($"Total de coelhos: {tipoC}");
Console.WriteLine($"Total de ratos: {tipoR}");
Console.WriteLine($"Total de sapos: {tipoS}");
Console.WriteLine($"Percentual de coelhos: {percentualC:P2}");
Console.WriteLine($"Percentual de ratos: {percentualR:P2}");
Console.WriteLine($"Percentual de sapos: {percentualS:P2}");

