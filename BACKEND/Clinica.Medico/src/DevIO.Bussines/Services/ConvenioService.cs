using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Bussines.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ConvenioService : BaseService, IConvenioService
    {
        private readonly IConvenioRepository _convenioRepository;

        public ConvenioService(IConvenioRepository convenioRepository, INotificador notificador) : base(notificador)
        {
            _convenioRepository = convenioRepository;
        }

        public async Task Adicionar(Convenio convenio)
        {
            if (!ExecutarValidacao(new ConvenioValidation(), convenio)) return;

            await _convenioRepository.Adicionar(convenio);
        }

        public async Task Atualizar(Convenio convenio)
        {
            if (!ExecutarValidacao(new ConvenioValidation(), convenio)) return;

            await _convenioRepository.Atualizar(convenio);
        }

        public void Dispose()
        {
            _convenioRepository?.Dispose();
        }

        public async Task Remover(string id)
        {
            await _convenioRepository.Remover(id);
        }
    }
}
