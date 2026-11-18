using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Usuario que contrata un plan y ve el catalogo. Hereda de Usuario.
    /// </summary>
    public class Cliente : Usuario
    {
        /// <summary>
        /// Constructor: todo cliente nuevo tiene rol CLIENTE.
        /// </summary>
        public Cliente()
        {
            Rol = "CLIENTE";
        }
        /// <summary>
        /// Mensaje de bienvenida del cliente.
        /// </summary>
        public override string ObtenerBienvenida()
        {
            return "¡Hola, " + Nombre + "! Qué bueno verte de nuevo en NovaStream.";
        }
    }
}
