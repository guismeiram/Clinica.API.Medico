using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class PacienteViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Idade { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public ConsultaViewModel Consulta { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        public virtual IEnumerable<PacienteTipoPagamentoViewModel> PacienteTipoPagamentos { get; set; }


    }
}
