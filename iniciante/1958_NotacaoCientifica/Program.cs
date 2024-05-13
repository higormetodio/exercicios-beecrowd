string numero = Console.ReadLine();

if (numero.Equals("-0"))
    Console.WriteLine(Convert.ToDouble(numero).ToString("-0.0000E+00"));
else if (numero.StartsWith("-") && Convert.ToDouble(numero) <= 0)
    Console.WriteLine(Convert.ToDouble(numero).ToString("0.0000E+00"));
else
    Console.WriteLine(Convert.ToDouble(numero).ToString("+0.0000E+00"));

