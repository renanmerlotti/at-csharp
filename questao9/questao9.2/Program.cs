using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao9
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string[] estoque = new string[5];
            int totalProdutos = 0;

            while (true)
            {
                Console.WriteLine("Digite uma opcao: ");
                Console.WriteLine("1 - Inserir produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");

                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    if (totalProdutos >= 5)
                    {
                        Console.WriteLine("Limite de 5 produtos atingido");
                        continue;
                    }

                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Quantidade: ");
                    string quantidade = Console.ReadLine();

                    Console.WriteLine("Preco unitario: ");
                    string preco = Console.ReadLine();

                    estoque[totalProdutos] = nome + " | " + quantidade + " | " + preco;
                    totalProdutos++;
                }
                else if (op == 2)
                {
                    for (int i = 0; i < totalProdutos; i++)
                    {
                        Console.WriteLine(estoque[i]);
                    }
                }
                else if (op == 3)
                {
                    break;
                }
            }
        }
    }
}