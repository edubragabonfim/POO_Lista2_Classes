namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Livro l1 = new Livro("Sapiens", "Harari", 234);

            l1.AtualizaTempoLeitura(6);
            int rate = 0;

            // Simula várias avaliações
            for (int i = 0; i < 17; i++)
            {
                rate = rand.Next(3, 6);
                l1.ReceberAvaliacao(rate);
            }

            Console.WriteLine(l1.Relatorio());
        }
    }
}
