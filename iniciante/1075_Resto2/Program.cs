int numero = Convert.ToInt32(Console.ReadLine());

if (numero < 10000)
{
    for (int i = 2; i < 10000; i++)
    {
        if (i % numero == 2)
        {
            Console.WriteLine(i);
        }
    }
}
