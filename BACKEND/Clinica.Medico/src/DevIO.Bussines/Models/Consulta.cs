
namespace DevIO.Bussines.Models
{
    public class Consulta : Entity
    {
        public string MedicoId { get; set; }
        public string ClinicaId { get; set; }
        public string PacienteId { get; set; }

        public DateTime Data { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }


    }
}