int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 2 && numero < 1000)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} x {numero} = {i * numero}");
    }
}
