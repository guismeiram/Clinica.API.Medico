using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IConvenioRepository : IRepository<Convenio>
    {
        Task<IEnumerable<Convenio>> ObterConvenio(String convenioId);

    }
}
