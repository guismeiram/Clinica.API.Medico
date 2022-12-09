using DevIO.Bussines.Models;
using Newtonsoft.Json;

namespace DevIO.Api.ViewModels
{
    public class ConsultaViewModel 
    {
        public string Id { get; set; }
        public string MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        // relacionamentos
        public virtual MedicoViewModel Medicos { get; set; }

    }
}