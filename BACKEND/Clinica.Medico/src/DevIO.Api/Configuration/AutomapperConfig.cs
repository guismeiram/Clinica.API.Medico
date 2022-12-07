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
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            

        }
    }
}