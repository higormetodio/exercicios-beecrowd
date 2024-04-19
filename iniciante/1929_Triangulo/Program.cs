string[] valores = Console.ReadLine()!.Split(' ');
char resultado;

int a = Convert.ToInt32(valores[0]);
int b = Convert.ToInt32(valores[1]);
int c = Convert.ToInt32(valores[2]);
int d = Convert.ToInt32(valores[3]);

int ab = a + b;
int ac = a + c;
int ad = a + d;
int bc = b + c;
int bd = b + d;
int cd = c + d;

if (a < bc && b < ac && c < ab)
    resultado = 'S';
else if (a < bd && b < ad && d < ab)
    resultado = 'S';
else if (a < cd && c < ad && d < ac)
    resultado = 'S';
else if (b < cd && c < bd && d < bc)
    resultado = 'S';
else
    resultado = 'N';

Console.WriteLine(resultado);