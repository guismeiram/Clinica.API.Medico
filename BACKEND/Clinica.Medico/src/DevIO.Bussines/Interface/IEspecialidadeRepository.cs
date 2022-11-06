using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IEspecialidadeRepository : IRepository<Especialidade>
    {
        Task<IEnumerable<Especialidade>> ObterEspecialidadeMedico(string especialidadeId);

    }
}
