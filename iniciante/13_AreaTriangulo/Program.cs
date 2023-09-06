string[] valores = Console.ReadLine().Split(' ');
double _valorA = double.Parse(valores[0]);
double _valorB = double.Parse(valores[1]);
double _valorC = double.Parse(valores[2]);
double _pi = 3.14159;

Console.WriteLine($"TRIANGULO: {_valorA * _valorC / 2.0:F3}");
Console.WriteLine($"CIRCULO: {_pi * Math.Pow(_valorC, 2):F3}");
Console.WriteLine($"TRAPEZIO: {(_valorA + _valorB) * _valorC / 2:F3}");
Console.WriteLine($"QUADRADO: {Math.Pow(_valorB, 2):F3}");
Console.WriteLine($"RETANGULO: {_valorA * _valorB:F3}");
