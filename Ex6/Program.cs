using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data(2, 11, 2025);
            Data d2 = new Data(8, 12, 2025);

            Console.WriteLine(d1.DataMaiorQue(d2));
            Console.WriteLine(d2.DataMaiorQue(d1));

            //Console.WriteLine(d1.Impressao());
            //Console.WriteLine(d2.Impressao());

            Console.WriteLine($"Data 1: {d1.Impressao()} | Inteirizada: {Data.InterizaDatas(d1)}");
            Console.WriteLine($"Data 2: {d2.Impressao()} | Inteirizada: {Data.InterizaDatas(d2)}");

            Console.WriteLine(Data.InterizaDatas(d1) - Data.InterizaDatas(d2));

        }
    }
}
