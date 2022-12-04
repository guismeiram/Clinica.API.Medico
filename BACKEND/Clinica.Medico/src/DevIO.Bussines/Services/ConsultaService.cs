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
        private readonly IMedicoRepository _medicoRepository;

        public ConsultaService(INotificador notificador, 
                        IConsultaRepository consultaRepository,
                        IMedicoRepository medicoRepository) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _medicoRepository = medicoRepository;
        }

        public async Task Adicionar(Consulta consulta)
        {
            if (!ExecutarValidacao(new ConsultaValidation(), consulta) || 
                !ExecutarValidacao(new MedicoValidation(), consulta.Medico) 
               ) return;

            await _consultaRepository.Adicionar(consulta);
        }

        public Task Atualizar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _consultaRepository?.Dispose();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
