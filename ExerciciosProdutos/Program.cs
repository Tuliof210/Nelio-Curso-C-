using System;
using Vendas.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantos Produtos: ");
            int N = int.Parse(Console.ReadLine());

            List<Produto> produtos = new List<Produto>();

            string nome;
            double price;
            char op;

            for(int i=1; i<=N; i++)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"Produto #{i}:");
                Console.Write("Normal, Usado ou Importado? (n/u/i): ");
                char.TryParse(Console.ReadLine().ToLower(), out op);
                Console.Write("Informe o nome do produto: ");
                nome = Console.ReadLine();
                Console.Write("Informe o preço: ");
                double.TryParse(Console.ReadLine(), out price);

                if (op == 'n')
                {
                    produtos.Add(new Produto(nome, price));
                }
                else if (op == 'u')
                {
                    Console.Write("Informe a data da fabricação (dd/MM/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(date, nome, price));
                }
                else if (op == 'i')
                {
                    Console.Write("Informe a taxa da alfandega: ");
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(taxa, nome, price));
                }
            }

            Console.WriteLine("\n\nETIQUETAS:\n");
            foreach(Produto p in produtos)
            {
                Console.WriteLine(p.Etiqueta());
            }

            Console.ReadKey();
        }
    }
}
