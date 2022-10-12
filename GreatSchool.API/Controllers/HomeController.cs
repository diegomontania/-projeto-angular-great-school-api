using Microsoft.AspNetCore.Mvc;
using Models;

namespace GreatSchool.API.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //retorna apresentacao
        public ApresentacaoAPI Index()
        {
            return new ApresentacaoAPI();
        }
    }
}
