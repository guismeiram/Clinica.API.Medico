using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IEspecialidadeService : IDisposable
    {
        Task Adicionar(Especialidade especialidade);
        Task Atualizar(Especialidade especialidade);
        Task Remover(String id);
        Task AtualizarEspecialidade(Especialidade especialidade);
    }
}
