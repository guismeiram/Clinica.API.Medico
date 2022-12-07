using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : MainController
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IMedicoService _medicoService;
        private readonly IConsultaRepository _consultaRepository;
        private readonly IMapper _mapper;
        public MedicoController(IConsultaRepository consultaRepository, IMedicoService medicoService, IMedicoRepository medicoRepository,INotificador notificador, IMapper mapper) : base(notificador)
        {
            _consultaRepository = consultaRepository;
            _mapper = mapper;
            _medicoRepository = medicoRepository;
            _medicoService = medicoService;
        }

        [HttpGet]
        public async Task<IEnumerable<MedicoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<MedicoViewModel>>(await _medicoRepository.ObterTodos());
        }

        [HttpPost]
        public async Task<ActionResult<MedicoViewModel>> Adicionar(MedicoViewModel medicoViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _medicoService.Adicionar(_mapper.Map<Medico>(medicoViewModel));

            return CustomResponse(medicoViewModel);
        }
    }
}
