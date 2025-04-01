namespace questao5
{
    internal class Program
    {
        static void Main()
        {
            DateTime formatura = new DateTime(2026, 12, 15);
            Console.WriteLine("Digite a data atual (dd/mm/aaaa):");

            DateTime hoje = DateTime.Parse(Console.ReadLine());

            if (hoje > DateTime.Now)
            {
                Console.WriteLine("Erro: Você não pode digitar uma data futura!");
                return;
            }

            if (hoje >= formatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = formatura.Year - hoje.Year;
            int meses = formatura.Month - hoje.Month;
            int dias = formatura.Day - hoje.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(hoje.Year, hoje.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            if(anos > 0)
            {
                Console.WriteLine("Faltam " + anos + " anos " + meses + " meses e " + dias + " dias para sua formatura");
            }
        }
    }
}
