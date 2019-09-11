using System;
using System.Collections.Generic;
using System.Linq;
using Curso.Entities;

namespace Curso.Interfaces
{
    interface IPaymentServices
    {
        List<Parcela> Processar(int quant, Contrato c);
    }
}
