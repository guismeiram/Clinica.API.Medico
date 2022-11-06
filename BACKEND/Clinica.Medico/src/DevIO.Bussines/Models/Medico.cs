using DevIO.Bussines.Models;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        // relacionamentos
        public virtual Consulta Consultas { get; set; }
        public virtual IEnumerable<MedicoEspecialidade> Especialidades { get; set; }

    }
}