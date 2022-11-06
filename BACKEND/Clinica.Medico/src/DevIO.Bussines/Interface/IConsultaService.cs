using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IConsultaService : IDisposable
    {
        Task Adicionar(Consulta consulta);
        Task Atualizar(Consulta consulta);
        Task Remover(Guid id);

        Task AtualizarEndereco(Consulta consulta);
    }
}
