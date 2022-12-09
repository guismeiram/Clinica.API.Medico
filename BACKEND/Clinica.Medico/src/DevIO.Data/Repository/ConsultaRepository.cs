﻿using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Consulta> obterConsultaClinica(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente()
        {
            return await Db.Consulta.AsNoTracking().Include(f => f.Medicos)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        public Task<Consulta> ObterConsultaPaciente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
