using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities;
using Pedido.Entities.Enums;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações do cliente:");
            Console.Write("Nome: ");
            string auxname = Console.ReadLine();
            Console.Write("Email: ");
            string auxemail = Console.ReadLine();
            Console.Write("Data de aniversario (dd/MM/yyyy): ");
            DateTime auxdate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(auxname, auxemail, auxdate);


            Console.WriteLine("\nEntre com as informações do pedido: ");
            Console.Write("Status: ");
            OrderStatus auxorder = new OrderStatus();
            Enum.TryParse(Console.ReadLine(), out auxorder);
            Console.Write("Quantos produtos? ");
            int quant = int.Parse(Console.ReadLine());

            Orders o1 = new Orders(DateTime.Now, auxorder, c1);


            string auxproductname;
            double auxprice;
            int auxquant;
            Product auxp;
            OrderItem auxo;

            for (int x = 1; x <= quant; x++)
            {
                Console.WriteLine($"\nEntre com a informação do {x}º produto");
                Console.Write("Nome do produto: ");
                auxproductname = Console.ReadLine();
                Console.Write("Preço: ");
                auxprice = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                auxquant = int.Parse(Console.ReadLine());

                auxp = new Product(auxproductname, auxprice);
                auxo = new OrderItem(auxquant, auxprice, auxp);
                o1.AddItem(auxo);
            }

            Console.WriteLine($"\nSumário do Pedido:\n----------------------------------\n{o1}");
            Console.WriteLine($"Itens do Pedido:\n{o1.AllItens()}");
            Console.WriteLine($"Preço Total do Pedido: R${o1.Total().ToString("F2")}");

            Console.ReadKey();
        }
    }
}
