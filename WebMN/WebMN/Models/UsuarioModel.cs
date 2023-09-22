using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMN.Entities;

namespace WebMN.Models
{
    public class UsuarioModel
    {

        public void IniciarSesion(UsuarioEnt entidad)
        { 
            //LLAMAR AL WEB API PARA VALIDAR EL USUARIO
        }

        public void RegistrarCuenta(UsuarioEnt entidad)
        {
            //LLAMAR AL WEB API PARA REGISTRAR EL USUARIO
        }

        public void RecuperarCuenta(UsuarioEnt entidad)
        {
            //LLAMAR AL WEB PARA VALIDAR EL USUARIO Y ENVIARLE UN CORREO
        }

    }
}