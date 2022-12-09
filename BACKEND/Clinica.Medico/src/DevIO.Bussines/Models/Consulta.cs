
using Newtonsoft.Json;

namespace DevIO.Bussines.Models
{
    public class Consulta : Entity
    {
        public string MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        // relacionamentos
        public virtual Medico Medicos { get; set; }

    }
}