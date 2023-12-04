// Ler duas coordenadas
// Verificar se a variável X ou Y é zero.
// Caso de sim, ecerra o programa
// Do contrário verifica as condilções abaixo:
// Se X maior que zero e Y maior que zero imprimir: primeiro
// Se X maior que zero e Y menor que zero imprimir: quarto
// Se X menor que zero e Y menor que zero imprimir: terceiro
// Se X menor que zero e Y maior que zero imprimir: segundo

string[] valores = Console.ReadLine().Split(' ');
int valorX = Convert.ToInt32(valores[0]);
int valorY = Convert.ToInt32(valores[1]);

while (valorX != 0 && valorY != 0)
{
    if (valorX > 0 && valorY > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (valorX > 0 && valorY < 0)
    {
        Console.WriteLine("quarto");
    }
    else if (valorX < 0 && valorY < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("segundo");
    }

    valores = Console.ReadLine().Split(' ');
    valorX = Convert.ToInt32(valores[0]);
    valorY = Convert.ToInt32(valores[1]);
}