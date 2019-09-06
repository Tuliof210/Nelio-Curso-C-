using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class ContaEmpresa : Conta
    {
        public double Limite { get; protected set; }

        //Reaproveitando o Construtor da superclasse
        public ContaEmpresa(int numero, double saldo, string titular, double limite) : base(numero, saldo, titular)
        {
            Limite = limite;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Titular: {Titular}");
            texto.AppendLine($"Numero: {Numero}");
            texto.AppendLine($"Saldo atual: ${Saldo.ToString("F2")}");
            texto.AppendLine($"Limite de emprestismo: ${Limite.ToString("F2")}");
            return texto.ToString();
        }

        public override double Sacar(double x)
        {
            double taxa = 1.02;
            return Saldo - (x * taxa);
        }
    }
}
