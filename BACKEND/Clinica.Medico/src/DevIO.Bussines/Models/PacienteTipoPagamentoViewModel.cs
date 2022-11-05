using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class PacienteTipoPagamentoViewModel
    {
        public string Id { get; set; }
        public string PacienteId { get; set; }
        public string TipoPagamentoId { get; set; }

        // relacionamentos
        public virtual PacienteViewModel Paciente { get; set; }
        public virtual TipoPagamentoViewModel TipoPagamento { get; set; }
    }
}
