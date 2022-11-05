using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class EnderecoViewModel 
    {
        public string Id { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string MedicoId { get; set; }
        public string EnderecoId { get; set; }

        // relacionamentos

        public virtual ClinicaViewModel Clinica { get; set; }


    }
}
