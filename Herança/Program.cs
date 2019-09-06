using System;
using Banco.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos diferentes mas com referencias do mesmo tipo
            Conta c1 = new Conta(11727, 590.00, "Tulio Ferreira");
            Conta c2 = new ContaEmpresa(52386, 100000, "Julia Medeiros", 1000);

            Console.WriteLine($"{c1}\n{c2}");

            //Nao é possivel fazer Console.WriteLine(c2.Limite);

            //como resolver:
            if(c2 is ContaEmpresa)
            {
                //"converta" para o tipo correto
                ContaEmpresa aux = c2 as ContaEmpresa;
                Console.WriteLine(aux.Limite);
            }

            Console.ReadKey();
        }
    }
}
