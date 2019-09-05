using System;
using Empresa.Entities;
using Empresa.Entities.Enums;
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
            Console.Write("Digite o nome do departamento: ");
            string auxDep = Console.ReadLine();
            Department d = new Department(auxDep);

            Console.WriteLine("\nEntre com as informações do trabalhador");
            Console.Write("Nome: ");
            string auxName = Console.ReadLine();

            //conversao string-enum
            Console.Write("Nivel (Junior/MidLevel/Senior): ");
            WorkerLevel auxLvl = new WorkerLevel();
            Enum.TryParse(Console.ReadLine(), out auxLvl);

            Console.Write("Salario Base: ");
            double auxSalary = double.Parse(Console.ReadLine());
            Console.Write("Quantos contratos esse trabalhador possui? ");
            int quant = int.Parse(Console.ReadLine());

            Worker trabalhador = new Worker(auxName, auxLvl, auxSalary, d);

            DateTime auxdata;
            double auxvalue;
            int auxduration;
            for (int i = 1; i <= quant; i++)
            {
                Console.Clear();
                Console.WriteLine($"\nEntre com as informações do {i}º contrato:");
                Console.Write("Data (dd/MM/yyyy): ");
                auxdata = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                auxvalue = double.Parse(Console.ReadLine());
                Console.Write("Duraçao em horas: ");
                auxduration = int.Parse(Console.ReadLine());

                trabalhador.AddContract(new HourContract(auxdata, auxvalue, auxduration));
            }

            Console.Write("\nEntre com um mes e ano (MM/yyyy) para calcular o ganho: ");
            string[] dados = Console.ReadLine().Split('/');

            Console.WriteLine($"\nNome: {trabalhador.Name}" +
                $"\nDepartamento: {trabalhador.Department}" +
                $"\nGanho: {trabalhador.Income(int.Parse(dados[0]), int.Parse(dados[1]))}");

            Console.ReadKey();
        }
    }
}
