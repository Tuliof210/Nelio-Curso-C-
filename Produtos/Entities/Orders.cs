using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Orders
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client Client { get; private set; }

        public List<OrderItem> Itens { get; private set; } = new List<OrderItem>();

        public Orders() { }

        public Orders(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem i)
        {
            Itens.Add(i);
        }
        public void RemoveItem(OrderItem i)
        {
            Itens.Remove(i);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public string AllItens()
        {
            StringBuilder aux = new StringBuilder();

            foreach(OrderItem x in Itens)
            {
                aux.Append($"{x.Item.Name}, ");
                aux.Append($"R${x.Price.ToString("F2")}, ");
                aux.Append($"Quantidade: {x.Quant}, ");
                aux.AppendLine($"Subtotal: R${x.SubTotal().ToString("F2")}");
            }

            return aux.ToString();
        }

        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine($"Momento do Pedido: {Moment}");
            aux.AppendLine($"Status do Pedido: {Status}");
            aux.Append($"Cliente: {Client.Name} ");
            aux.Append($"({Client.BirthDate.Day}/{Client.BirthDate.Month}/{Client.BirthDate.Year})");
            aux.AppendLine($" - {Client.Email}");


            return aux.ToString();
        }
    }
}
