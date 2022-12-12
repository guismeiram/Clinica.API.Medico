using DevIO.Api.ViewModels;
using DevIO.Bussines.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevIO.Api.ViewModels
{
    public class MedicoViewModel 
    {
        //ids
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }

        //autommaper
        public string? Nome { get; set; }
        public string? NomeClinica { get; set; }


        public string? Crm { get; set; }
        public string? Idade { get; set; }
        public string? Telefone { get; set; }
        public string? Ddd { get; set; }


        // relacionamentos
        public IEnumerable<ConsultaViewModel>? Consultas { get; set; }

    }
}