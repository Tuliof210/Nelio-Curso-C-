using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class OrderItem
    {
        public int Quant { get; private set; }
        public double Price { get; private set; }

        public Product Item { get; private set; }

        public OrderItem() { }

        public OrderItem(int quant, double price, Product item)
        {
            Quant = quant;
            Price = price;
            Item = item;
        }

        public double SubTotal()
        {
            return Price * Quant;
        }
    }
}
