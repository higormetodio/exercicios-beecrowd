int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 5 && numero < 2000)
{
    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
        }
    }
}
