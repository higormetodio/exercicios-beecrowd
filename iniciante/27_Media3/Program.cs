string[] notas = Console.ReadLine().Split();
double nota1 = Convert.ToDouble(notas[0]);
double nota2 = Convert.ToDouble(notas[1]);
double nota3 = Convert.ToDouble(notas[2]);
double nota4 = Convert.ToDouble(notas[3]);

double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 4.0 + nota4 * 1.0) / 10.0;

Console.WriteLine($"Media: {Math.Round(media, 1):F1}");

if (media >= 5.0 && media <= 6.9)
{
    AlunoEmExame(Math.Round(media, 1));
}
else if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}

static void AlunoEmExame(double media)
{
    Console.WriteLine("Aluno em exame.");

    double notaExame = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {notaExame:F1}");

    double mediaFinal = (media + notaExame) / 2.0;

    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
    }

    Console.WriteLine($"Media final: {mediaFinal:F1}");
}