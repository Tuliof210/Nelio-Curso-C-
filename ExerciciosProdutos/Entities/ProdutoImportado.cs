using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Entities
{
    class ProdutoImportado : Produto
    {
        public double Alfandega { get; protected set; }

        public ProdutoImportado(double alfandega, string nome, double price) :
            base(nome, price)
        {
            Alfandega = alfandega;
        }

        protected double TotalPrice()
        {
            return Price + Alfandega;
        }

        public override string Etiqueta()
        {
            return $"{Nome} - ${TotalPrice().ToString("F2")} (Custos Alfandega: ${Alfandega})";
        }
    }
}
