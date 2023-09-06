double _raio = int.Parse(Console.ReadLine());
double _pi = 3.14159;

double _volume = (4.0 / 3.0) * _pi * Math.Pow(_raio, 3);

Console.WriteLine($"VOLUME = {_volume:F3}");