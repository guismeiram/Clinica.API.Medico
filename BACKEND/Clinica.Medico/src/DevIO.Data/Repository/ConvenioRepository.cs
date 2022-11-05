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
    public class ConvenioRepository : Repository<Convenio>, IConvenioRepository
    {

        public ConvenioRepository(ClinicaDbContext db) : base(db)
        {

        }

        public async Task<IEnumerable<Convenio>> ObterConvenio(string convenioId)
        {
            return await Buscar(p => p.Id == convenioId);
        }
    }
}
