int QT = Convert.ToInt32(Console.ReadLine());
int contador = 0;

while (contador < QT)
{
    string[] escolhas = Console.ReadLine().Split(' ');
    string[] jogadores = { escolhas[0], escolhas[2] };
    string[] jogadas = { escolhas[1].ToLower(), escolhas[3].ToLower() };
    string[] N = Console.ReadLine().Split(' ');
    int soma = Convert.ToInt32(N[0]) + Convert.ToInt32(N[1]);
    string resultado;

    if (soma % 2 == 0)
        resultado = "par";
    else
        resultado = "impar";

    for (int i = 0; i < 2; i++)
    {
        if (jogadas[i] == resultado)
        {
            Console.WriteLine(jogadores[i]);
            break;
        }
    }

    contador++;
}
