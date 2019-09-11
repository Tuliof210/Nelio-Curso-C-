using System;

namespace Curso.Entities
{
    class Parcela
    {
        public DateTime DataParcela { get; set; }
        public double ValorParcela { get; set; }

        public Parcela(DateTime dataParcela, double valorParcela)
        {
            DataParcela = dataParcela;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"{DataParcela.ToString("dd/MM/yyyy")} - $ {ValorParcela.ToString("F2")}";
        }
    }
}
