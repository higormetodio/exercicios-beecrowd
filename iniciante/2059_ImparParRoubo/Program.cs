string[] valores = Console.ReadLine().Split(' ');

int p = Convert.ToInt32(valores[0]);
int j1 = Convert.ToInt32(valores[1]);
int j2 = Convert.ToInt32(valores[2]);
int r = Convert.ToInt32(valores[3]);
int a = Convert.ToInt32(valores[4]);

int ehPar = (j1 + j2) % 2;
string resultado;

if (p == 1 && ehPar == 0 && r == 0 && a == 0 ||
    p == 1 && ehPar == 0 && r == 1 && a == 0 ||
    p == 1 && ehPar != 0 && r == 1 && a == 0 ||
    p == 0 && ehPar != 0 && r == 0 && a == 0 ||
    p == 0 && ehPar != 0 && r == 1 && a == 0 ||
    p == 0 && ehPar == 0 && r == 1 && a == 0 ||
    p == 1 && ehPar == 0 && r == 0 && a == 1 ||
    p == 1 && ehPar != 0 && r == 0 && a == 1 ||
    p == 0 && ehPar != 0 && r == 0 && a == 1 ||
    p == 0 && ehPar == 0 && r == 0 && a == 1)
    resultado = "Jogador 1 ganha!";
else
    resultado = "Jogador 2 ganha!";

Console.WriteLine(resultado);
