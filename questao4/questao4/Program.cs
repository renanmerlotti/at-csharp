namespace questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            int diasFaltando = (proximoAniversario - hoje).Days;

            if(diasFaltando < 7)
            {
                Console.WriteLine("Seu aniversario esta quase chegando! Faltam apenas: " + diasFaltando + " dias");
            } else
            {
                Console.WriteLine("Faltam " + diasFaltando + " para o seu aniversario");
            }
        }
    }
}
