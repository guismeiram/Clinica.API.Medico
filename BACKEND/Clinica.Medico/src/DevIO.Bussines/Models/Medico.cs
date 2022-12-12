using DevIO.Bussines.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Bussines.Models
{
    public class Medico : Entity
    {
        //autommaper
        public string? Nome { get; set; }
        public string? NomeClinica { get; set; }



        public string? Crm { get; set; }
        public string? Idade { get; set; }
        public string? Telefone { get; set; }
        public string? Ddd { get; set; }


        // relacionamentos

        public IEnumerable<Consulta>? Consultas { get; set; }


    }
}