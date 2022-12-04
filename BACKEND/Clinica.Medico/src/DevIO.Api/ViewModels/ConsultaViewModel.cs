namespace DevIO.Api.ViewModels
{
    public class ConsultaViewModel 
    {
        public string id { get; set; }  
        public string MedicoId { get; set; }
    

        public DateTime Data { get; set; }

        // relacionamentos
        public virtual MedicoViewModel Medico { get; set; }

    }
}