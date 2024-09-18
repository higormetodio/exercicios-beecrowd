string[] dados = Console.ReadLine().Split(' ');

for (int i = 0; i < 3; i++)
{
    if (dados[i] == "0")
        dados[i] = "24";
}

int saida = Convert.ToInt32(dados[0]);
int duracao = Convert.ToInt32(dados[1]);
int fuso = Convert.ToInt32(dados[2]);


int resultado = saida + duracao + fuso;

if (resultado > 24)
    Console.WriteLine(resultado - 24);
else if (resultado < 24)
    Console.WriteLine(resultado);
else
    Console.WriteLine(0);
