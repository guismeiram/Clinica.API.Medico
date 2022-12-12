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
    public class ConsultaService : BaseService, IConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaService(INotificador notificador, 
                        IConsultaRepository consultaRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;
        }

        public async Task Adicionar(Consulta consulta)
        {
            if (!ExecutarValidacao(new ConsultaValidation(), consulta) 
               ) return;

            await _consultaRepository.Adicionar(consulta);
        }

        public async Task Atualizar(Consulta consulta)
        {
            if (!ExecutarValidacao(new ConsultaValidation(), consulta)) return;

            await _consultaRepository.Atualizar(consulta);
        }

        public void Dispose()
        {
            _consultaRepository?.Dispose();
        }

        public async Task Remover(string id)
        {
            await _consultaRepository.Remover(id);
        }
    }
}
