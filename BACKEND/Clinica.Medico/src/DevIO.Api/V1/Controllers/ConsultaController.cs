using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Bussines.Services;
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



        [HttpPost]
        public async Task<ActionResult<ConsultaViewModel>> Adicionar(ConsultaViewModel consultaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _consultaService.Adicionar(_mapper.Map<Consulta>(consultaViewModel));

            return CustomResponse(consultaViewModel);
        }

        [HttpGet]
        [Route("ObterConsultaPorId", Name = "ObterConsultaPorId")]
        public async Task<ActionResult<ConsultaViewModel>> ObterConsultaPorId(string id)
        {
            ConsultaViewModel consulta = await ObterConsultaMedica(id);

            if (consulta == null) return NotFound();
            if (id == null) return NotFound();

            return Ok(consulta);
        }

        [HttpPut]
        [Route("ObterConsultaPorId", Name = "ObterConsultaPorId")]
        public async Task<ActionResult<ConsultaViewModel>> Atualizar(string id, ConsultaViewModel consultaViewModel)
        {
            if (id != consultaViewModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(consultaViewModel);
            }

            var consultaAtualizacao = await ObterConsultaMedica(id);

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            consultaAtualizacao.Id = consultaViewModel.Id;
            consultaAtualizacao.Nome = consultaViewModel.Nome;
            consultaAtualizacao.Data = consultaViewModel.Data;
            consultaAtualizacao.Medicos.Id = consultaViewModel.Medicos.Id;
            consultaAtualizacao.Medicos.Idade = consultaViewModel.Medicos.Idade;
            consultaAtualizacao.Medicos.Ddd = consultaViewModel.Medicos.Ddd;
            consultaAtualizacao.Medicos.Crm = consultaViewModel.Medicos.Crm;
            consultaAtualizacao.Medicos.Nome = consultaViewModel.Medicos.Nome;
            consultaAtualizacao.Medicos.NomeClinica = consultaViewModel.Medicos.NomeClinica;
            consultaAtualizacao.Medicos.Telefone = consultaViewModel.Medicos.Telefone;

            await _consultaService.Atualizar(_mapper.Map<Consulta>(consultaAtualizacao));

            return CustomResponse(consultaViewModel);
        }



        private async Task<ConsultaViewModel> ObterConsultaMedica(string id)
        {
            return _mapper.Map<ConsultaViewModel>(await _consultaRepository.obterConsultaMedica(id));
        }

        [HttpDelete]
        [Route("ObterConsultaPorId", Name = "ObterConsultaPorId")]
        public async Task<ActionResult<ConsultaViewModel>> Excluir(string id)
        {
            ConsultaViewModel consulta = await ObterConsultaMedica(id);

            if (consulta == null) return NotFound();
            if (id == null) return NotFound();

            await _consultaService.Remover(id);

            return CustomResponse(consulta);
        }
    }
}
