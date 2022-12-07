using DevIO.Api.Controllers;
using DevIO.Bussines.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : MainController
    {
        public ClinicaController(INotificador notificador) : base(notificador)
        {

        }

       
    }
}
