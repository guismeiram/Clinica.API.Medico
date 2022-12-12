using DevIO.Bussines.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevIO.Api.ViewModels
{
    public class ConsultaViewModel 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        public string? MedicoId { get; set; }
        public DateTime Data { get; set; }
        public string? Nome { get; set; }
        // relacionamentos
        public MedicoViewModel? Medicos { get; set; }

    }
}