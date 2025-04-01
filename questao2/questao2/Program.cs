namespace questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: " );
            String nome = Console.ReadLine();

            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] >= 'A' && nome[i] <= 'Z')
                {
                    Console.Write((char)((nome[i] - 'A' + 2) % 26 + 'A'));
                }
                else if (nome[i] >= 'a' && nome[i] <= 'z')
                {
                    Console.Write((char)((nome[i] - 'a' + 2) % 26 + 'a'));
                }
                else
                {
                    Console.Write(nome[i]); 
                }
            }
        }
    }
}
