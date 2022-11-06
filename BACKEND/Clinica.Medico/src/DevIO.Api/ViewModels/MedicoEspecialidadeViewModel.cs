namespace DevIO.App.ViewModels
{
    public class MedicoEspecialidadeViewModel
    {
        public String Id { get; set; }
        public string MedicoId { get; set; }
        public string EspecialidadeId { get; set; }

        // relacionamentos
        public virtual MedicoViewModel Medico { get; set; }
        public virtual EspecialidadeViewModel Especialidade { get; set; }
    }
}