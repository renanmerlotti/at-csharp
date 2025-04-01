namespace questao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 7 + 7 + 7;
            Aluno a1 = new Aluno("Renan", "123231", "ADS", media);

            a1.ExibirDados();
            a1.VerificarAprovacao();

        }
    }
}
