string especie = Console.ReadLine();
string subEspecie = Console.ReadLine();
string subEspecieAlimento = Console.ReadLine();


if (especie == "vertebrado" && subEspecie == "ave" && subEspecieAlimento == "carnivoro")
{
    Console.WriteLine("aguia");
}
else if (especie == "vertebrado" && subEspecie == "ave" && subEspecieAlimento == "onivoro")
{
    Console.WriteLine("pomba");
}
else if (especie == "vertebrado" && subEspecie == "mamifero" && subEspecieAlimento == "onivoro")
{
    Console.WriteLine("homem");
}
else if (especie == "vertebrado" && subEspecie == "mamifero" && subEspecieAlimento == "herbivoro")
{
    Console.WriteLine("vaca");
}
else if (especie == "invertebrado" && subEspecie == "inseto" && subEspecieAlimento == "hematofago")
{
    Console.WriteLine("pulga");
}
else if (especie == "invertebrado" && subEspecie == "inseto" && subEspecieAlimento == "herbivoro")
{
    Console.WriteLine("lagarta");
}
else if (especie == "invertebrado" && subEspecie == "anelideo" && subEspecieAlimento == "hematofago")
{
    Console.WriteLine("sanguessuga");
}
else if (especie == "invertebrado" && subEspecie == "anelideo" && subEspecieAlimento == "onivoro")
{
    Console.WriteLine("minhoca");
}


if (especie == "vertebrado")
{
    if (subEspecie == "ave")
    {
        if (subEspecieAlimento == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else
        {
            Console.WriteLine("pomba");
        }
    }
    else
    {
        if (subEspecieAlimento == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else
        {
            Console.WriteLine("vaca");
        }
    }
}
else
{
    if (subEspecie == "inseto")
    {
        if (subEspecieAlimento == "hermatofogo")
        {
            Console.WriteLine("pulga");
        }
        else
        {
            Console.WriteLine("lagarta");
        }
    }
    else
    {
        if (subEspecieAlimento == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else
        {
            Console.WriteLine("minhoca");
        }
    }
}
