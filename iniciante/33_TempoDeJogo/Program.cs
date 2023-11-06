string[] tempos = Console.ReadLine().Split();

int horaInicio = Convert.ToInt32(tempos[0]);
int horaFim = Convert.ToInt32(tempos[1]);

TimeSpan tempoTotal = TimeSpan.FromHours(horaFim + 24 - horaInicio);

if (tempoTotal.Hours == 0)
{
    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
}
else
{
    Console.WriteLine($"O JOGO DUROU {tempoTotal.Hours} HORA(S)");
}

