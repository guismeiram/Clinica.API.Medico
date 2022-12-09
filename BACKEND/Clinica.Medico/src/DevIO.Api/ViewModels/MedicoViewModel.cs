using DevIO.Api.ViewModels;
using DevIO.Bussines.Models;
using Newtonsoft.Json;

namespace DevIO.Api.ViewModels
{
    public class MedicoViewModel 
    {
        //ids
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }


        // relacionamentos
        public virtual ClinicaViewModel Clinicas { get; set; }
        public virtual IEnumerable<ConsultaViewModel> Consultas { get; set; }

    }
}