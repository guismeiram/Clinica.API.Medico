using DevIO.Bussines.Models;

namespace DevIO.Api.ViewModels
{
    public class ConsultaViewModel 
    {
        public string Id { get; set; }
        public string MedicoId { get; set; }
        public DateTime Data { get; set; }

        // relacionamentos
        public virtual MedicoViewModel Medicos { get; set; }

    }
}