using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entities
{
    class Funcionario
    {
        public string Nome { get; protected set; }
        public double ValorHora { get; protected set; }
        public int Horas { get; protected set; }

        public Funcionario(string nome, double valorHora, int horas)
        {
            Nome = nome;
            ValorHora = valorHora;
            Horas = horas;
        }

        public virtual double Pagamento()
        {
            return ValorHora * Horas;
        }
    }
}
