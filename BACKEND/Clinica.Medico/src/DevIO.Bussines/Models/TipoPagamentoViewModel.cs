using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class TipoPagamentoViewModel
    {
        public string Id { get; set; }
        public PagamentoViewModel Pagamentos { get; set; }
        public ConvenioViewModel Convenios { get; set; }

        public virtual IEnumerable<PacienteTipoPagamentoViewModel> PacienteTipoPagamentos { get; set; }

    }
}
