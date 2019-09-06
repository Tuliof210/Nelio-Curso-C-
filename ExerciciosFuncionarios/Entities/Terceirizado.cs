using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Entities
{
    class Terceirizado :  Funcionario
    {
        public double Adicional { get; protected set; }

        public Terceirizado(double adicional, string nome, double valorHora, int horas) :
            base(nome, valorHora, horas)
        {
            Adicional = adicional;
        }

        public override double Pagamento()
        {
            return (ValorHora * Horas) + (Adicional * 1.1);
        }
    }
}
