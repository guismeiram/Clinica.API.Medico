using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IClinicaRepository : IRepository<Clinica>
    {
        Task<Clinica> obterClinicaPorConsulta(string id);


    }
}
