using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ClinicaService : BaseService, IClinicaService
    {
        public ClinicaService(INotificador notificador) : base(notificador)
        {
        }

        public Task Adicionar(Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Clinica clinica)
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
