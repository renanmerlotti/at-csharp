using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    internal class Funcionario
    {
        private String nome;
        private String cargo;
        private double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }

        public virtual double calcularSalario()
        {
            return salarioBase;
        }
    }
}
