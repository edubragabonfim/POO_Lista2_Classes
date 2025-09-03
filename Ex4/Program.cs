namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Aluno eduardo = new Aluno("856193", "EDUARDO");

            eduardo.FazerAtividadeAvaliativa(5);
            eduardo.FazerAtividadeAvaliativa(5);
            eduardo.FazerReavaliacao(1);

            Console.WriteLine(eduardo.Relatorio());
        }
    }
}
