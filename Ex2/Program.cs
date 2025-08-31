namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(20, 2);

            calc.AlterarNumero2(0);

            Console.WriteLine("Soma: " + calc.Soma());
            Console.WriteLine("Subtração: " + calc.Subtracao());
            Console.WriteLine("Multiplicação: " + calc.Multiplicacao());
            Console.WriteLine("Divisão: " + calc.Divisao());
        }
    }
}
