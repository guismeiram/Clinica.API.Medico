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
    public class MedicoService : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IClinicaRepository _clinicaRepository;

        public MedicoService(INotificador notificador,
                              IMedicoRepository medicoRepository,
                              IClinicaRepository clinicaRepository) : base(notificador)
        {
            _medicoRepository = medicoRepository;
            _clinicaRepository = clinicaRepository;
        }

        public async Task<bool> Adicionar(Medico medico)
        {
            if(!ExecutarValidacao(new MedicoValidation(), medico) ||
                !ExecutarValidacao(new ClinicaValidation(), medico.Clinicas))

            await _medicoRepository.Adicionar(medico);
            return true;
        }

        public Task<bool> Atualizar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _medicoRepository?.Dispose();
            _clinicaRepository?.Dispose();
        }

        public Task<bool> Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
