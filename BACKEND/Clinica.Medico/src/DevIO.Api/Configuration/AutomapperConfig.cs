using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Bussines.Models;

namespace DevIO.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
           
            CreateMap<Consulta, ConsultaViewModel>().ReverseMap();
            CreateMap<Especialidade, EspecialidadeViewModel>().ReverseMap();
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            CreateMap<MedicoEspecialidade, MedicoEspecialidadeViewModel>().ReverseMap();
            

        }
    }
}