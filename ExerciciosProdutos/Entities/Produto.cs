using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Entities
{
    class Produto
    {
        public string Nome { get; protected set; }
        public double Price { get; protected set; }

        public Produto(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public virtual string Etiqueta()
        {
            return $"{Nome} - ${Price.ToString("F2")}";
        }
    }
}
