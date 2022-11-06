using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IMedicoService : IDisposable
    {
        Task Adicionar(Medico medico);
        Task Atualizar(Medico medico);
        Task Remover(String id);
        Task AtualizarMedico(Medico medico);
    }
}
