using System;
using Empresa.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantos funcionários: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            string nome;
            int horas;
            double valorHora, adicional;
            bool question;

            for(int i=1; i<=N; i++)
            {
                Console.WriteLine("\n-----------------------------");
                Console.Write("Informe o nome: ");
                nome = Console.ReadLine();
                Console.Write("Informe horas trabalhadas: ");
                int.TryParse(Console.ReadLine(), out horas);
                Console.Write("Informe Valor/h: ");
                double.TryParse(Console.ReadLine(), out valorHora);

                Console.Write("Terceirizado?(y = true/n = false): ");
                bool.TryParse(Console.ReadLine(), out question);

                if (question)
                {
                    Console.Write("Informe valor das despesas: ");
                    double.TryParse(Console.ReadLine(), out adicional);

                    funcionarios.Add(new Terceirizado(adicional, nome, valorHora, horas));
                    continue;
                }

                funcionarios.Add(new Funcionario(nome, valorHora, horas));
            }

            Console.WriteLine("\n\nRelatorio Pagamentos\n---------------------------------");
            foreach(Funcionario f in funcionarios)
            {
                Console.Write($"{f.Nome}");
                Console.WriteLine($" - ${f.Pagamento().ToString("F2")}");
            }

            Console.ReadKey();
        }
    }
}
