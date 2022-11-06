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
    public class EspecialidadeService : BaseService, IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeService(INotificador notificador) : base(notificador)
        {
        }

        public async Task Adicionar(Especialidade especialidade)
        {
            if (!ExecutarValidacao(new EspecialidadeValidation(), especialidade)) return;

            await _especialidadeRepository.Adicionar(especialidade);
        }

        public Task Atualizar(Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEspecialidade(Especialidade especialidade)
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
