string[] valores = Console.ReadLine().Split(' ');
int valorA = Convert.ToInt32(valores[0]);
int valorB = Convert.ToInt32(valores[1]);
int resto;
int quociente;

for (resto = 0; resto < Math.Abs(valorB); resto++)
{
    if ((valorA - resto) % valorB == 0)
    {
        quociente = (valorA - resto) / valorB;
        Console.WriteLine($"{quociente} {resto}");
        break;
    }
}

