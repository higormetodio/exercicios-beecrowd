int senha = 2002;
int valor;

do
{
    valor = Convert.ToInt32(Console.ReadLine());

    if (senha == valor)
    {
        Console.WriteLine("Acesso Permitido");
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }

} while (senha != valor);
