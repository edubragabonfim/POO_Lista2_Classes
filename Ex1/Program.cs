namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ContaBancaria c1 = new ContaBancaria("2345678", "08515645696", 100);

            Console.WriteLine($"Deposito de {400:C2} | Saldo Atual: {c1.Depositar(400):C2}");
            Console.WriteLine($"Deposito de {200:C2} | Saldo Atual: {c1.Depositar(200):C2}");

            c1.AtualizaLimite(300);

            Console.WriteLine(c1.Relatorio());

            Console.WriteLine();

            Console.WriteLine($"Saque de {850:C2} | Saldo Restante: {c1.Sacar(850):C2}");

            Console.WriteLine($"Deposito de {450:C2} | Saldo Atual: {c1.Depositar(450):C2}");

            Console.WriteLine(c1.Relatorio());
        }
    }
}
