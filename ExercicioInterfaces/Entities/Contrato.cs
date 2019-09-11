using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Exceptions;
using Curso.Interfaces;

namespace Curso.Entities
{
    class Contrato
    {
        public int Number { get; set; }
        public DateTime Data { get; set; }
        public double Value { get; set; }
        public IPaymentServices PaymentService { get; set; }

        //public List<Parcela> Parcelas { get; set; } = new List<Parcela>();

        public Contrato(int number, DateTime data, double value, IPaymentServices paymentService)
        {
            Number = number;
            Data = data;
            Value = value;
            PaymentService = paymentService;
        }

        public List<Parcela> GerarParcelas(int quant)
        {
            if (quant < 1) throw new DomainException("Não é possivel parcelar o contrato em 0 parcelas");
            return PaymentService.Processar(quant, this);
        }
    }
}
