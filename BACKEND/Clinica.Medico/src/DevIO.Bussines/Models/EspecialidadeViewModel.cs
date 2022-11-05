using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class EspecialidadeViewModel
    {
        public string id { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<MedicoEspecialidadeViewModel> Medicos { get; set; }

    }
}
