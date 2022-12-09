﻿using DevIO.Bussines.Models;
using Newtonsoft.Json;

namespace DevIO.Api.ViewModels
{
    public class ClinicaViewModel
    {
        public string Id { get; set; }
        public string NomeClinica { get; set; }
        public virtual MedicoViewModel Medicos { get; set; }
        public string MedicoId { get; set; }
    }
}
