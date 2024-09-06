
while (true)
{
    if (!decimal.TryParse(Console.ReadLine(), out decimal volume))
        break;

    if (!decimal.TryParse(Console.ReadLine(), out decimal diamentro))
        break;

    decimal pi = 3.14m;
    decimal raio = diamentro / 2;
    decimal altura = volume / (pi * raio * raio);
    decimal area = pi * raio * raio;

    Console.WriteLine($"ALTURA = {altura:F2}");
    Console.WriteLine($"AREA = {area:F2}");
}
