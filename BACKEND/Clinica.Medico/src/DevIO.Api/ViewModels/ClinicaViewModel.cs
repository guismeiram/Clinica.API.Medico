using DevIO.Bussines.Models;

namespace DevIO.Api.ViewModels
{
    public class ClinicaViewModel
    {
        public string Id { get; set; }
        public string NomeClinica { get; set; }

        public virtual Medico Medicos { get; set; }
        public string MedicoId { get; set; }
    }
}
