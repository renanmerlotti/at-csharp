namespace questao11
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Gerenciador de Contatos");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    StreamWriter sw = File.AppendText("contatos.txt");
                    sw.WriteLine(nome + "," + telefone + "," + email);
                    sw.Close();

                    Console.WriteLine("Contato cadastrado com sucesso!\n");
                }
                else if (opcao == "2")
                {
                    if (!File.Exists("contatos.txt") || new FileInfo("contatos.txt").Length == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nContatos cadastrados:");
                        StreamReader sr = new StreamReader("contatos.txt");
                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(',');
                            Console.WriteLine("Nome: " + dados[0] + " | Telefone: " + dados[1] + " | Email: " + dados[2]);
                        }
                        sr.Close();
                        Console.WriteLine();
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Encerrando programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!\n");
                }
            }
        }
    }
}
