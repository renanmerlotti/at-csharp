using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase) : base(nome, cargo, salarioBase)
        {
        }

        public override double calcularSalario()
        {
            return SalarioBase * 1.2;
        }
    }
}
