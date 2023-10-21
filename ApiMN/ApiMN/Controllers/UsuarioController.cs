using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMN.Controllers
{
    public class UsuarioController : ApiController
    {

        [HttpGet]
        [Route("ConsultaUsuarios")]
        public List<TUsuario> ConsultaUsuarios()
        {
            try
            {
                using (var context = new BDMNEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    var datos = (from x in context.TUsuario
                                 select x).ToList();

                    return datos;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("ConsultarProvincias")]
        public List<System.Web.Mvc.SelectListItem> ConsultarProvincias()
        {
            try
            {
                using (var context = new BDMNEntities())
                {
                    var datos = (from x in context.TProvincia
                                 select x).ToList();

                    var respuesta = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        respuesta.Add(new System.Web.Mvc.SelectListItem { Value = item.ConProvincia.ToString(), Text = item.Descripcion });
                    }

                    return respuesta;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
