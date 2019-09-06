using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class Conta
    {
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }
        public string Titular { get; protected set; }

        public Conta(int numero, double saldo, string titular)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Titular: {Titular}");
            texto.AppendLine($"Numero: {Numero}");
            texto.AppendLine($"Saldo atual: ${Saldo.ToString("F2")}");
            return texto.ToString();
        }

        //para que um metodo da superclasse possa ser sobreescrito ele precisa ser Virtual ou abstract ou overrided
        public virtual double Sacar(double x)
        {
            return Saldo - x;
        }
    }
}
