namespace questao10
{
    internal class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 51);
            int tentativas = 5;

            Console.WriteLine("Adivinhe o numero entre 1 e 50, voce tem 5 tentativas");

            while (tentativas > 0)
            {
                Console.Write("Seu palpite: ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: numero fora do escopo de 1 a 50");
                    continue;
                }

                if (palpite == numero)
                {
                    Console.WriteLine("Acertou");
                    return;
                }

                tentativas--;
            }

            Console.WriteLine("Errou, o numero era: " + numero);
        }
    }
}
