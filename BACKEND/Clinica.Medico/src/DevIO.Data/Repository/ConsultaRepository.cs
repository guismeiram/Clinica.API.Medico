using DevIO.Bussines.Interface;
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

        public async Task<IEnumerable<Consulta>> obterConsultaClinicaPaciente(string id)
        {
            return await Db.Consulta.Where(a => a.Id == id)
               .Include(a => a.Medico)
               .ToListAsync();
        }

        public Task<Consulta> ObterConsultaPaciente(string id)
        {
            throw new NotImplementedException();
        }
    }
}
