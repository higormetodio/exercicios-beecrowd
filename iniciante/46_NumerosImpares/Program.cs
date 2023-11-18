int valor = Convert.ToInt32(Console.ReadLine());

if (valor >= 1 && valor <= 1000)
{
    for (int i = 1; i <= valor; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
