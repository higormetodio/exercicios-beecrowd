int tempo = Convert.ToInt32(Console.ReadLine());
TimeSpan timeSpan = TimeSpan.FromSeconds(tempo);
int hour = (int)timeSpan.TotalHours;
int minutes = timeSpan.Minutes;
int seconds = timeSpan.Seconds;

Console.WriteLine($"{hour}:{minutes}:{seconds}");