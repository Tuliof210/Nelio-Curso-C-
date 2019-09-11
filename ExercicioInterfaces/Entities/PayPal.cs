using System;
using System.Collections.Generic;
using Curso.Interfaces;

namespace Curso.Entities
{
    class PayPal : IPaymentServices
    {
        public double Mensal { get; private set; } = 0.01;
        public double Total { get; private set; } = 0.02;

        public List<Parcela> Processar(int quant, Contrato c)
        {
            double auxvalue;
            List<Parcela> aux = new List<Parcela>();
            DateTime auxdata = c.Data;

            for (int i = 1; i <= quant; i++)
            {
                auxvalue = c.Value / quant;

                auxvalue += auxvalue * Mensal * i;
                auxvalue += auxvalue * Total;
                auxdata = auxdata.AddMonths(1);

                aux.Add(new Parcela(auxdata, auxvalue));
            }

            return aux;
        }
    }
}
