using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IConvenioService : IDisposable
    {
        Task Adicionar(Convenio convenio);
        Task Atualizar(Convenio convenio);
        Task Remover(String id);

    }
}
