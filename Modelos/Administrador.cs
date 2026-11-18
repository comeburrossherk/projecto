using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Usuario que administra el catalogo y ve las estadisticas. Hereda de Usuario.
    /// </summary>
    public class Administrador : Usuario
    {
        /// <summary>
        /// Constructor: todo administrador tiene rol ADMIN.
        /// </summary>
        public Administrador()
        {
            Rol = "ADMIN";
        }
        /// <summary>
        /// Mensaje de bienvenida del administrador.
        /// </summary>
        public override string ObtenerBienvenida()
        {
            return "Panel de administración. Bienvenido, " + Nombre + ".";
        }
    }
}
