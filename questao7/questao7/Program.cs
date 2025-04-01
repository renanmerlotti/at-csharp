namespace questao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb1 = new ContaBancaria("Renan", 0);

            cb1.ExibirSaldo();
            Console.WriteLine();
            cb1.Depositar(500);
            cb1.ExibirSaldo();
            Console.WriteLine();
            cb1.Sacar(700);
            cb1.ExibirSaldo();
            Console.WriteLine();
            cb1.Sacar(200);
            cb1.ExibirSaldo();
        }
    }
}
