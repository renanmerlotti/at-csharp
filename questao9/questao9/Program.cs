namespace questao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create("estoque.txt");
            fs.Close();


            while (true) {
                Console.WriteLine("Digite uma opcao: ");
                Console.WriteLine("1 - Inserir produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");

                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    int totalProdutos = 0;
                    StreamReader contador = new StreamReader("estoque.txt");
                    while (contador.ReadLine() != null) totalProdutos++;
                    contador.Close();

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

                    StreamWriter sw = File.AppendText("estoque.txt");
                    sw.WriteLine(nome + " | " + quantidade + " | " + preco);
                    
                    sw.Close();
                }
                else if (op == 2)
                {
                    StreamReader sr = new StreamReader("estoque.txt");

                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    sr.Close();
                }
                else if (op == 3) 
                {
                    break;
                }

            }
        }
    }
}
