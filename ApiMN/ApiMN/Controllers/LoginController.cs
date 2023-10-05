using System.Web.Http;
using ApiMN.Entities;

namespace ApiMN.Controllers
{
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("RegistrarCuenta")]
        public void RegistrarCuenta(UsuarioEnt entidad)
        {

        }

        [HttpPost]
        [Route("IniciarSesion")]
        public void IniciarSesion(UsuarioEnt entidad)
        {

        }        

    }
}
