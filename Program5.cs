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
            //conjuntos
            //nao pode haver repetição
            //nao indice
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);


            //for comum nao funciona
            Console.Write("Conjunto A:");
            foreach(int x in A)
            {
                Console.Write($" {x}");
            }

            Console.Write("\nConjunto B:");
            foreach (int x in B)
            {
                Console.Write($" {x}");
            }
            Console.WriteLine("\n-----------------");

            int aux = 9;

            //Verifica se o elemento esta contido no conjunto
            if (A.Contains(aux)) Console.WriteLine($"{aux} pertence a A");
            else Console.WriteLine($"{aux} não pertence a A");

            if (B.Contains(aux)) Console.WriteLine($"{aux} pertence a B");
            else Console.WriteLine($"{aux} não pertence a B");

            //remocão: conjunto<tipo>.Remove(tipo);

            A.IntersectWith(B); //elementos comuns de B e A
            Console.Write("\nConjunto A att:");
            foreach (int x in A)
            {
                Console.Write($" {x}");
            }

            A.ExceptWith(B); //remove elementos de B em A
            Console.Write("\nConjunto A att:");
            foreach (int x in A)
            {
                Console.Write($" {x}");
            }

            A.UnionWith(B); //concatena elementos de B em A
            Console.Write("\nConjunto A att:");
            foreach (int x in A)
            {
                Console.Write($" {x}");
            }

            Console.ReadKey();
        }
    }
}
