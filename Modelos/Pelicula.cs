using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Contenido de tipo pelicula. Hereda de Contenido.
    /// </summary>
    public class Pelicula : Contenido
    {
        public Pelicula()
        {
            Tipo = "pelicula";
        }
        /// <summary>
        /// Detalle que se muestra en el catalogo para las peliculas.
        /// </summary>
        public override string ObtenerDetalle()
        {
            return "pelicula . " + DuracionMin + " min";
        }
    }
}
