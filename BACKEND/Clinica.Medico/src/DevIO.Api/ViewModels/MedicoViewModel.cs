namespace DevIO.App.ViewModels
{
    public class MedicoViewModel 
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        // relacionamentos
        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual ConsultaViewModel Consultas { get; set; }
        public virtual List<MedicoEspecialidadeViewModel> Especialidades { get; set; }

    }
}