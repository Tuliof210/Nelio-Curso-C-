using System.Collections.Generic;
using Curso.Entities;

namespace Curso.Interfaces
{
    interface IPaymentServices
    {
        List<Parcela> Processar(int quant, Contrato c);
    }
}
