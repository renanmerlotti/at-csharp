namespace questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero 1: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2: ");
            double num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma das opcoes abaixo para selecionar a operacao matematica: ");
            Console.WriteLine("1 - Adicao");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");

            int opcao;
            opcao = int.Parse(Console.ReadLine());

            double resultado;

            if (opcao == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado da sua operacao de adicao é: " + resultado);
            }
            else if (opcao == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("O resultado da sua operacao de subtracao é: " + resultado);
            }
            else if (opcao == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("O resultado da sua operacao de multiplicacao é: " + resultado);
            }
            else if (opcao == 4) 
            {
                if (num2 == 0) 
                {
                    Console.WriteLine("Erro: Nao é possivel dividir por 0");
                } 
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da sua operacao de divisao é: " + resultado);
                }
            }

        }
    }
}
