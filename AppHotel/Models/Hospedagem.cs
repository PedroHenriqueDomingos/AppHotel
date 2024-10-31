using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    internal class Hospedagem
    {
        public Quartos QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCrianca { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adulta = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_crianca = QntCrianca * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adulta + valor_crianca) * Estadia;
                return total;
            }
        }
    }
}
