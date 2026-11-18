using System;
using System.Collections.Generic;
using System.Text;
using suscripciones_proyecto_intento1.Modelos;
namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Guarda al usuario que inició sesión para que cualquier formulario lo pueda usar.
    /// </summary>
    public static class Sesion
    {
        public static Usuario UsuarioActual { get; set; }
    }
}
