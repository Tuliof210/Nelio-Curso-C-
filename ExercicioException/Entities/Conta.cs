using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Exception;

namespace Curso.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public double LimiteSaque { get; private set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = saldo * 0.5;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0) throw new DomainException("Não é possível realizar depositos de valores inferiores a $1");
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0) throw new DomainException("Não é possível realizar saques de valores inferiores a $1");
            if (valor > LimiteSaque) throw new DomainException("O valor informado é maior que seu limite atual de saque");
            if (valor > Saldo) throw new DomainException("Saldo insuficiente");
            Saldo -= valor;
        }
    }
}
