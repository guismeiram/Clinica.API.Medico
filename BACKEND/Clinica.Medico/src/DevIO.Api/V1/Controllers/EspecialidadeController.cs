using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : MainController
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;
        private readonly IEspecialidadeService _especialidadeService;
        private readonly IMapper _mapper;

        public EspecialidadeController(INotificador notificador,
                                  IMapper mapper,
                                  IEspecialidadeRepository especialidadeRepository,
                                  IEspecialidadeService especialidadeService) : base(notificador)
        {
            _mapper = mapper;
            _especialidadeRepository = especialidadeRepository;
            _especialidadeService = especialidadeService;
        }

        [HttpGet]
        public async Task<IEnumerable<EspecialidadeViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<EspecialidadeViewModel>>(await _especialidadeRepository.ObterTodos());
        }

        /*[HttpGet]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ConvenioViewModel> ObterEnderecoPorId(string id)
        {
            var convenio = await ObterConvenio(id);

            //if (convenio == null) return NotFound();

            return convenio;
        }*/

        [HttpPost]
        public async Task<ActionResult<EspecialidadeViewModel>> Adicionar(EspecialidadeViewModel especialidadeViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _especialidadeService.Adicionar(_mapper.Map<Especialidade>(especialidadeViewModel));

            return CustomResponse(especialidadeViewModel);
        }

        /*
        [HttpPut]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ActionResult<ConvenioViewModel>> Atualizar(string id, ConvenioViewModel convenioViewModel)
        {
            if (id != convenioViewModel.id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(convenioViewModel);
            }

            var convenioAtualizacao = await ObterConvenio(id);

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            convenioAtualizacao.id = convenioViewModel.id;
            convenioAtualizacao.Nome = convenioViewModel.Nome;
            convenioAtualizacao.Vencimento = convenioViewModel.Vencimento;
            convenioAtualizacao.NCarteira = convenioViewModel.NCarteira;

            await _convenioService.Atualizar(_mapper.Map<Convenio>(convenioViewModel));

            return CustomResponse(convenioViewModel);
        }

        [HttpDelete]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ActionResult<ConvenioViewModel>> Excluir(string id)
        {
            var convenioViewModel = await ObterConvenio(id);

            // if (convenioViewModel == null) return NotFound();

            await _convenioService.Remover(id);

            return CustomResponse(convenioViewModel);
        }


        private async Task<ConvenioViewModel> ObterConvenio(string id)
        {
            return _mapper.Map<ConvenioViewModel>(await _convenioRepository.ObterPorId(id));
        }*/
    }
}
