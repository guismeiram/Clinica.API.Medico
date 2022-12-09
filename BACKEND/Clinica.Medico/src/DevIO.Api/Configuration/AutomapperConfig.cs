using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            CreateMap<Clinica, ClinicaViewModel>().ReverseMap();
            CreateMap<ConsultaViewModel, Consulta>();

            CreateMap<Consulta, ConsultaViewModel>().ForMember(x => x.Nome, opt => opt.MapFrom(src => src.Medicos.Nome));
        }
    }
}