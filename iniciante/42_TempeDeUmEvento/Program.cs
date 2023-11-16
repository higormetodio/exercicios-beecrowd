// string[] valorInicio = Console.ReadLine().Split(' ');
// TimeSpan diaInicio = TimeSpan.FromDays(Convert.ToInt32(valorInicio[1]));
// string[] tempoInicio = Console.ReadLine().Split(':');
// TimeSpan horaInicio = TimeSpan.FromHours(Convert.ToInt32(tempoInicio[0]));
// TimeSpan minutoInicio = TimeSpan.FromMinutes(Convert.ToInt32(tempoInicio[1]));
// TimeSpan segundoInicio = TimeSpan.FromSeconds(Convert.ToInt32(tempoInicio[2]));
// TimeSpan inicio = diaInicio + horaInicio + minutoInicio + segundoInicio;

// string[] valorFim = Console.ReadLine().Split(' ');
// TimeSpan diaFim = TimeSpan.FromDays(Convert.ToInt32(valorFim[1])); ;
// string[] tempoFim = Console.ReadLine().Split(':');
// TimeSpan horaFim = TimeSpan.FromHours(Convert.ToInt32(tempoFim[0]));
// TimeSpan minutoFim = TimeSpan.FromMinutes(Convert.ToInt32(tempoFim[1]));
// TimeSpan segundoFim = TimeSpan.FromSeconds(Convert.ToInt32(tempoFim[2]));
// TimeSpan fim = diaFim + horaFim + minutoFim + segundoFim;

// TimeSpan total = fim - inicio;

// Console.WriteLine($"{total.Days} dia(s)");
// Console.WriteLine($"{total.Hours} hora(s)");
// Console.WriteLine($"{total.Minutes} minuto(s)");
// Console.WriteLine($"{total.Seconds} segundo(s)");


string[] valorInicio = Console.ReadLine().Split(' ');
int diaInicio = Convert.ToInt32(valorInicio[1]);
string[] tempoInicio = Console.ReadLine().Split(':');
int horaInicio = Convert.ToInt32(tempoInicio[0]);
int minutoInicio = Convert.ToInt32(tempoInicio[1]);
int segundoInicio = Convert.ToInt32(tempoInicio[2]);

string[] valorFim = Console.ReadLine().Split(' ');
int diaFim = Convert.ToInt32(valorFim[1]);
string[] tempoFim = Console.ReadLine().Split(':');
int horaFim = Convert.ToInt32(tempoFim[0]);
int minutoFim = Convert.ToInt32(tempoFim[1]);
int segundoFim = Convert.ToInt32(tempoFim[2]);

int totalSegundos;
int totalMinutos;
int totalHoras;
int totalDias;

if (segundoInicio != segundoFim)
{
    totalSegundos = 60 - segundoInicio + segundoFim;
}
else
{
    totalSegundos = 0;
}

if (minutoInicio != minutoFim)
{
    totalMinutos = 60 - minutoInicio + minutoFim;
}
else
{
    totalMinutos = 0;
}

if (horaInicio != horaFim)
{
    totalHoras = 24 - horaInicio + horaFim;
}
else
{
    totalHoras = 0;
}

totalDias = diaFim - diaInicio;

if (totalSegundos > 60)
{
    totalSegundos -= 60;
}

if (totalMinutos > 60)
{
    totalMinutos -= 60;
}

if (totalHoras > 24)
{
    totalHoras -= 24;
}
else
{
    totalDias--;
}


Console.WriteLine($"{totalDias} dia(s)");
Console.WriteLine($"{totalHoras} hora(s)");
Console.WriteLine($"{totalMinutos} minuto(s)");
Console.WriteLine($"{totalSegundos} segundo(s)");


