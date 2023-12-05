int contador = 0;
double soma = 0.0;

int resposta = 1;
bool retorno = true;

while (retorno)
{
    if (resposta == 1)
    {
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
    }

    Console.WriteLine("novo calculo (1-sim 2-nao)");
    resposta = Convert.ToInt32(Console.ReadLine());
    soma = 0;
    contador = 0;

    if (resposta == 2)
    {
        retorno = false;
    }
}


