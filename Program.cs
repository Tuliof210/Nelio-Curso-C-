using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //nullable
            int? y = null;
            //formas de atribuição de valor nulo para variaveis do tipo valor(que nao aceitam nulo)
            Nullable<double> z = null;


            //caso queira atribuit um valor para variavel sem saber se o valor é nulo:
            int teste = y ?? 5;

            Console.WriteLine(teste);
            Console.ReadKey();
        }
    }
}
