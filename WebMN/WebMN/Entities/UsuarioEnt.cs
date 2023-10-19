﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMN.Entities
{
    public class UsuarioEnt
    {
        public long ConUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public bool Estado { get; set; }
        public string DescripcionProvincia { get; set; }
        public string DescripcionRol { get; set; }
    }
}