string[] tempos = Console.ReadLine().Split();
int horaInicial = Convert.ToInt32(tempos[0]);
int minutoInicial = Convert.ToInt32(tempos[1]);
int horaFinal = Convert.ToInt32(tempos[2]);
int minutoFinal = Convert.ToInt32(tempos[3]);

int tempoInicial = horaInicial * 60 + minutoInicial;
int tempoFinal = horaFinal * 60 + minutoFinal;

int tempoTotal = 0;

if (tempoFinal > tempoInicial)
{
    tempoTotal = tempoFinal - tempoInicial;
}
else
{
    tempoTotal = tempoFinal + 1440 - tempoInicial;
}

if (tempoTotal == 0)
{
    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
}
else
{
    Console.WriteLine($"O JOGO DUROU {tempoTotal / 60} HORA(S) E {tempoTotal % 60} MINUTO(S)");
}




