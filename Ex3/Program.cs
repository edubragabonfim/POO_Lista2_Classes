namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("PUF0514");

            Console.WriteLine(carro.ExibirVelocidade());

            carro.Acelerar(70);
            Console.WriteLine(carro.ExibirVelocidade());
            carro.Frear(30);
            Console.WriteLine(carro.ExibirVelocidade());

            //carro.ValidarVelocidade(10);

            carro.Acelerar(100); // Não pode mudar a velocidade
            Console.WriteLine(carro.ExibirVelocidade());
        }
    }
}
