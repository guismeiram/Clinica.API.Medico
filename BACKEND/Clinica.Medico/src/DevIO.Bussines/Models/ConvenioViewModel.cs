using System.ComponentModel.DataAnnotations;

namespace DevIO.App.ViewModels
{
    public class ConvenioViewModel 
    {
        public string id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String NCarteira { get; set; }
        [Required]
        public DateTime Vencimento { get; set; }


    }
}