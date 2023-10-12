using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMN.Entities;
using WebMN.Models;

namespace WebMN.Controllers
{
    public class LoginController : Controller
    {
        UsuarioModel usuarioModel = new UsuarioModel();

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            var resp = usuarioModel.IniciarSesion(entidad);

            if (resp != null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "Compruebe la información de sus credenciales";
                return View();
            }           
        }


        [HttpGet]
        public ActionResult RegistrarCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarCuenta(UsuarioEnt entidad)
        {
            entidad.Direccion = string.Empty;
            entidad.Estado = true;

            var resp = usuarioModel.RegistrarCuenta(entidad);

            if (resp == "OK")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha registrado su información";
                return View();
            }
        }


        [HttpGet]
        public ActionResult RecuperarCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            var resp = usuarioModel.RecuperarCuenta(entidad);

            if (resp == "OK")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha enviado el correo con su información";
                return View();
            }
        }

    }
}