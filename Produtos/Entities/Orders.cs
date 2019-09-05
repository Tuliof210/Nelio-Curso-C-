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
    }
}
