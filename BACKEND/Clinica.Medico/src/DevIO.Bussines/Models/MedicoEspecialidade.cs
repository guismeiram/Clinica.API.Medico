using DevIO.Bussines.Models;

namespace DevIO.Bussines.Models
{
    public class MedicoEspecialidade : Entity
    {
        public string MedicoId { get; set; }
        public string EspecialidadeId { get; set; }

        // relacionamentos
        public virtual Medico Medico { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}