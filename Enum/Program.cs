using System;
using Curso.Entities;
using Curso.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(pedido);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus),"Shipped");//String to Enum
            Console.WriteLine(os);

            Console.ReadKey();
        }
    }
}
