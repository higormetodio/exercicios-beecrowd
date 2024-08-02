string[] valores = Console.ReadLine().Split();
double A = Convert.ToDouble(valores[0]);
double B = Convert.ToDouble(valores[1]);

//double percentual = (B - A) / A
double percentual = (B - A) / A * 100;

//Console.WriteLine($"{percentual:P2}");
Console.WriteLine($"{percentual:F2}%");
