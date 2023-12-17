using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

int testes = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= testes; i++)
{
    string[] valores = Console.ReadLine().Split();
    int valorX = Convert.ToInt32(valores[0]);
    int valorY = Convert.ToInt32(valores[1]);
    int soma = 0;
    int nImpares = 0;

    do
    {
        if (valorX % 2 != 0)
        {
            soma += valorX;
            valorX++;
            nImpares++;
        }
        else
        {
            valorX++;
        }
    } while (nImpares < valorY);

    Console.WriteLine(soma);
}
