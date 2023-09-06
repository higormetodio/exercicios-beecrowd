namespace Salario
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int numeroHoras = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = {(valorPorHora * numeroHoras).ToString("F")}");

        }
    }
}
