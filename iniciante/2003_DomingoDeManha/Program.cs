while (true)
{
    if (!TimeSpan.TryParseExact(Console.ReadLine(), "h\\:mm", null, out TimeSpan saida))
    {
        break;
    }

    TimeSpan percurso = TimeSpan.ParseExact("1:00", "h\\:mm", null);
    TimeSpan horaDoEncontro = TimeSpan.ParseExact("8:00", "h\\:mm", null);

    TimeSpan tempoDeChegada = saida + percurso;
    TimeSpan atrasoMaximo = tempoDeChegada - horaDoEncontro;

    if (atrasoMaximo.TotalMinutes >= 0)
    {
        Console.WriteLine($"Atraso maximo: {atrasoMaximo.TotalMinutes}");
    }
    else
    {
        Console.WriteLine("Atraso maximo: 0");
    }
}
