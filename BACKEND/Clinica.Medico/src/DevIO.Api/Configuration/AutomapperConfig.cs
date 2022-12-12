using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<MedicoViewModel, Medico>().ReverseMap();
            CreateMap<ConsultaViewModel, Consulta>();

            //one to many
            CreateMap<Consulta, ConsultaViewModel>()
                .ForMember(x => x.Nome, opt => opt.MapFrom(src => src.Medicos.Nome));
                


        }
    }
}