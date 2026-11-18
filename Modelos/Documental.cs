using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Contenido de tipo documental. Hereda de Contenido.
    /// </summary>
    public class Documental : Contenido
    {
        public Documental()
        {
            Tipo = "documental";
        }

        /// <summary>
        /// Detalle propio de los documentales.
        /// </summary>
        public override string ObtenerDetalle()
        {
            return "Documental - " + DuracionMin + " min";
        }
    }
}
