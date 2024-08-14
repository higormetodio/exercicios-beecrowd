int numeroAlunos = Convert.ToInt32(Console.ReadLine());
double maiorNota = 0.0;
int matriculaMaiorNota = 0;


for (int i = 0; i < numeroAlunos; i++)
{
    string[] valores = Console.ReadLine().Split();
    int matricula = Convert.ToInt32(valores[0]);
    double nota = Convert.ToDouble(valores[1]);

    if (nota > maiorNota)
    {
        maiorNota = nota;
        matriculaMaiorNota = matricula;
    }
}

if (maiorNota >= 8.0 && matriculaMaiorNota != 0)
{
    Console.WriteLine(matriculaMaiorNota);
}
else
{
    Console.WriteLine("Minimum note not reached");
}
