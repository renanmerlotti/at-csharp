using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    internal class Aluno
    {
        private String nome;
        private String matricula;
        private String curso;
        private double mediaNotas;

        public Aluno(string nome, string matricula, string curso, double mediaNotas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.mediaNotas = mediaNotas;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Curso { get => curso; set => curso = value; }
        public double MediaNotas { get => mediaNotas; set => mediaNotas = value; }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Media das notas: " + MediaNotas);
        }

        public void VerificarAprovacao()
        {
            if (MediaNotas >= 7)
            {
                Console.WriteLine("Voce foi aprovado");
            }
            else
            {
                Console.WriteLine("Voce foi reprovado");
            }
        }
    }
}
