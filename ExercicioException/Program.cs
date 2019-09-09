using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities;
using Curso.Exception;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular;
            Random r = new Random(1000);
            double saldo;

            Conta c1;

            try
            {
                Console.Write("Informe o titular: ");
                titular = Console.ReadLine();
                Console.Write("Informe o saldo inicial: ");
                saldo = double.Parse(Console.ReadLine());

                c1 = new Conta(r.Next(), titular, saldo);

                c1.Depositar(2080);
                c1.Sacar(-2080);

                Console.WriteLine(c1.Saldo);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
