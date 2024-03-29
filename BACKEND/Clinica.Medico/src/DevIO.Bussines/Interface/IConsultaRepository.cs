﻿using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IConsultaRepository : IRepository<Consulta>
    {
        Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente();
        Task<Consulta> obterConsultaMedica(String id);
        Task<Consulta> ObterConsultaPaciente(String id);
    }
}
