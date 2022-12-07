using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class ClinicaRepository : Repository<Clinica>, IClinicaRepository
    {
        public ClinicaRepository(ClinicaDbContext db) : base(db)
        {
        }

        public Task<Clinica> obterClinicaPorConsulta(string id)
        {
            throw new NotImplementedException();
        }
    }
}
