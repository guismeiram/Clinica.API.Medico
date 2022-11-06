using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class MedicoService : BaseService, IMedicoService
    {
        public MedicoService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
