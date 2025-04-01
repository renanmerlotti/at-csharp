namespace questao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Renan", "Funcionario", 10000);
            Gerente g1 = new Gerente("Jose", "Gerente", 10000);

            Console.WriteLine("Salario funcionario: " + f1.calcularSalario());
            Console.WriteLine("Salario gerente: " + g1.calcularSalario());
        }
    }
}
