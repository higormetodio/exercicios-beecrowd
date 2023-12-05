int contador = 0;
double soma = 0;

do
{
    double nota = Convert.ToDouble(Console.ReadLine());

    if (nota >= 0.0 && nota <= 10.0)
    {
        contador++;
        soma += nota;

    }
    else
    {
        Console.WriteLine("nota invalida");
    }

} while (contador < 2);

Console.WriteLine($"media = {soma / 2:F2}");
