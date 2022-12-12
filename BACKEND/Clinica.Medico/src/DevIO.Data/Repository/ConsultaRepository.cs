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

        public async Task<Consulta> obterConsultaMedica(string id)
        {
            return await Db.Consulta.AsNoTracking()
                .Include(c => c.Medicos)
                .FirstOrDefaultAsync(c => c.Id == id);
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
