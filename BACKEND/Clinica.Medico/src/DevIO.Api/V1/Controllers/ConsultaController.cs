using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/consulta")]
    public class ConsultaController : MainController
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IConsultaService _consultaService;
        private readonly IMapper _mapper;

        public ConsultaController(INotificador notificador,
                                  IMapper mapper,
                                  IConsultaRepository consultaRepository,
                                  IConsultaService consultaService) : base(notificador)
        {
            _mapper = mapper;
            _consultaRepository = consultaRepository;
            _consultaService = consultaService;
        }

        [HttpGet]
        public async Task<IEnumerable<ConsultaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ConsultaViewModel>>(await _consultaRepository.obterConsultaClinicaPaciente());
        }

        [HttpGet]
        [Route("ObterEnderecoPorId", Name = "ObterEnderecoPorId")]
        public async Task<ConsultaViewModel> ObterEnderecoPorId(string id)
        {
            var convenio = await ObterFornecedorProdutosEndereco(id);

            //if (convenio == null) return NotFound();

            return convenio;
        }

        [HttpPost]
        public async Task<ActionResult<ConsultaViewModel>> Adicionar(ConsultaViewModel consultaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _consultaService.Adicionar(_mapper.Map<Consulta>(consultaViewModel));

            return CustomResponse(consultaViewModel);
        }

        private async Task<ConsultaViewModel> ObterFornecedorProdutosEndereco(string id)
        {
            return _mapper.Map<ConsultaViewModel>(await _consultaRepository.ObterPorId(id));
        }
    }
}
