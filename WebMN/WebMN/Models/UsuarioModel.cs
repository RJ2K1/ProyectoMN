using System.Net.Http;
using System.Net.Http.Json;
using WebMN.Entities;

namespace WebMN.Models
{
    public class UsuarioModel
    {

        public UsuarioEnt IniciarSesion(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            { 
                string url = "https://localhost:44337/IniciarSesion";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<UsuarioEnt>().Result;
            }
        }

        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44337/RegistrarCuenta";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public string RecuperarCuenta(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44337/RecuperarCuenta";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<string>().Result;
            }
        }

    }
}