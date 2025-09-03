namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Aluno eduardo = new Aluno("856193", "EDUARDO");

            eduardo.FazerAtividadeAvaliativa(3);
            eduardo.FazerAtividadeAvaliativa(9);
            eduardo.FazerAtividadeAvaliativa(8);
            eduardo.FazerReavaliacao(1);

            Console.WriteLine(eduardo.Relatorio());
        }
    }
}
