using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMN.Models;

namespace WebMN.Controllers
{
    public class LoginController : Controller
    {
        //Esto es una instancia del modelo
        Usuario usuarioModel = new Usuario();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }        

    }
}