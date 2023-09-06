using System.Globalization;

//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

Console.Clear();

string[] peca1 = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');

double totalPeca1 = int.Parse(peca1[1]) * double.Parse(peca1[2]);
double totalPeca2 = int.Parse(peca2[1]) * double.Parse(peca2[2]);

double total = totalPeca1 + totalPeca2;

Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
