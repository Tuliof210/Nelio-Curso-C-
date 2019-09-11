using System;
using System.Collections.Generic;
using Curso.Entities;
using Curso.Exceptions;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, quant;
            double val;
            DateTime data;
            Contrato contrato = null;
            List<Parcela> parcelas = new List<Parcela>();

            try
            {
                Console.Write("Entre com as informações do Contrato\nNumero: ");
                num = int.Parse(Console.ReadLine());
                Console.Write("Informe a Data (dd/MM/yyyy): ");
                data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor: ");
                val = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de Parcelas: ");
                quant = int.Parse(Console.ReadLine());

                contrato = new Contrato(num, data, val, new PayPal());
                parcelas = contrato.GerarParcelas(quant);

                Console.WriteLine("\nParcelas:\n");
                foreach(Parcela p in parcelas)
                {
                    Console.WriteLine(p);
                }
            }
            catch(DomainException e)
            {
                Console.Write($"\n{e.Message}");
            }
            catch(FormatException e)
            {
                Console.Write($"\n{e.Message}");
            }

            Console.ReadKey();
        }
    }
}
