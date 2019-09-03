using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, int id, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double p)
        {
            Salario += Salario * (p / 100);
        }

        public override string ToString()
        {
            return ($"\nId:{Id}\nFuncionario: {Nome}\nSalario: R${Salario.ToString("F2")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            string auxnome;
            double auxsalario;
            int auxid;

            while(true)
            {
                Console.Write("Digite o id: ");
                auxid = int.Parse(Console.ReadLine());

                if (auxid == 0) break;

                Console.Write("Digite o nome: ");
                auxnome = Console.ReadLine();
                Console.Write("Digite o salario: ");
                auxsalario = double.Parse(Console.ReadLine());

                Console.WriteLine();

                list.Add(new Funcionario(auxnome, auxid, auxsalario));
            }

            foreach(Funcionario f in list)
            {
                Console.WriteLine(f);
            }

            Console.Write("\nDigite o Id do funcionario q deseja aumentar o salario: ");
            auxid = int.Parse(Console.ReadLine());

            Funcionario aux = list.Find(x => x.Id == auxid);//continua...

            if (aux != null)
            {
                Console.Write("Digite quantos % deseja aumentar o salario: ");
                aux.Aumento(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nDados atualizados\n-----------------------------------");
            foreach (Funcionario f in list)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}
