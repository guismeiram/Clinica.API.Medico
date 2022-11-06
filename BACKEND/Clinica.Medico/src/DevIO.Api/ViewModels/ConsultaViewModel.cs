namespace DevIO.App.ViewModels
{
    public class ConsultaViewModel 
    {
        public string id { get; set; }  
        public string MedicoId { get; set; }
        public string ClinicaId { get; set; }
        public string PacienteId { get; set; }

        public DateTime Data { get; set; }

        // relacionamentos
        public virtual MedicoViewModel Medico { get; set; }
        public virtual ClinicaViewModel Clinica { get; set; }
        public virtual PacienteViewModel Paciente { get; set; }

    }
}