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
            List<int> list = new List<int>();

            //adiçao ao final da lista
            list.Add(5);
            list.Add(55);
            list.Add(444);
            list.Add(545);
            list.Add(67);
            list.Add(98);
            list.Add(1233);
            list.Add(78);
            list.Add(69);
            list.Add(1);
            list.Add(9);
            list.Add(678);
            list.Add(1000);
            list.Add(60);
            list.Add(10);
            list.Add(29);
            list.Add(36);
            list.Add(77);
            list.Add(6);
            list.Add(2);
            list.Add(0);
            list.Add(466);
            list.Add(531);

            //adiciona em uma posiçao determinada
            list.Insert(3, 777);

            //o find recebe uma função como parametro para retornar a primeira ocorrencia(melhor entendimento com lambda)
            Console.WriteLine($"list.find: {list.Find(x => x > 60)}");//ex de labda expression
            //mesma logica, que retorna ultima ocorrencia
            Console.WriteLine($"list.findlast: {list.FindLast(x => x > 60)}");//ex de labda expression

            Console.WriteLine("-------------------------------------------");

            //ambos retorna o indice e nao o valor
            Console.WriteLine($"list.findindex: {list.FindIndex(x => x > 60)}");
            Console.WriteLine($"list.findlastindex: {list.FindLastIndex(x => x > 60)}");

            Console.WriteLine("-------------------------------------------");

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            //remove item da lista
            list.Remove(777);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List remove\n");
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            //remove item do indice informado
            list.RemoveAt(2);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List removeat\n");
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            //remove todos pertencentes a uma condição
            list.RemoveAll(x => x % 2 == 0);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List removeall\n");
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            //remove todos pertencentes a uma faixa
            list.RemoveRange(6, 3);//index inicial e quantidade

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("List removerenage\n");
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
