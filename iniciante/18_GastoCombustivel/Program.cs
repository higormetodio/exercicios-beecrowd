int horas = Convert.ToInt32(Console.ReadLine());
int velocidade = Convert.ToInt32(Console.ReadLine());

double litros = velocidade * horas / 12.0;

Console.WriteLine(litros.ToString("F3"));
