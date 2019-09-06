using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime Data { get; protected set; }

        public ProdutoUsado(DateTime data, string nome, double price) :
            base(nome, price)
        {
            Data = data;
        }

        public sealed override string Etiqueta()
        {
            return $"{Nome} (usado) - ${Price.ToString("F2")} (Fabricado: {Data.ToString("dd/MM/yyy")})";
        }
    }
}
