using System;
using System.Web.Http;
using ApiMN.Entities;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace ApiMN.Controllers
{
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new BDMNEntities())
                {
                    //var user = new TUsuario();
                    //user.Identificacion = entidad.Identificacion;
                    //user.Nombre = entidad.Nombre;
                    //user.Correo = entidad.Correo;
                    //user.Contrasenna = entidad.Contrasenna;
                    //user.Direccion = entidad.Direccion;
                    //user.Estado = entidad.Estado;

                    //context.TUsuario.Add(user);
                    //context.SaveChanges();

                    context.RegistrarCuenta_SP(entidad.Identificacion, entidad.Nombre, entidad.Correo, entidad.Contrasenna, entidad.Direccion, entidad.Estado);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public IniciarSesion_SP_Result IniciarSesion(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new BDMNEntities())
                {
                    //return (from x in context.TUsuario
                    //             where x.Correo == entidad.Correo
                    //                && x.Contrasenna == entidad.Contrasenna
                    //                && x.Estado == true
                    //             select x).FirstOrDefault();

                    return context.IniciarSesion_SP(entidad.Correo, entidad.Contrasenna).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("RecuperarCuenta")]
        public void RecuperarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new BDMNEntities())
                {
                    var datos = (from x in context.TUsuario
                                 where x.Identificacion == entidad.Identificacion
                                 select x).FirstOrDefault();

                    if (datos != null)
                    {
                        EnvioCorreos(datos.Correo, "Recuperar Contraseña", datos.Contrasenna);
                    }
                }
            }
            catch (Exception)
            {
                //return null;
            }
        }

        private void EnvioCorreos(string destino, string asunto, string contenido)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("ecalvo90415@ufide.ac.cr");
            message.To.Add(new MailAddress(destino));
            message.Subject = asunto;
            message.Body = contenido;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.Host = "smtp.office365.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("ecalvo90415@ufide.ac.cr", "XXXXXXXX");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

    }
}
