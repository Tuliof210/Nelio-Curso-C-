using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public Double Price { get; private set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
