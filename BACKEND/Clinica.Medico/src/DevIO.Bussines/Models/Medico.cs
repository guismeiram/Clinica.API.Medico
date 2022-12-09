using DevIO.Bussines.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        //ids
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }


        // relacionamentos
        public virtual Clinica Clinicas { get; set; }

        public virtual IEnumerable<Consulta> Consultas { get; set; }


    }
}