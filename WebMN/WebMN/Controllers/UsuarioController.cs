using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMN.Models;

namespace WebMN.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel model = new UsuarioModel();

        [HttpGet]
        public ActionResult PerfilUsuario()
        {
            ViewBag.Provincias = model.ConsultarProvincias();
            return View();
        }
    }
}