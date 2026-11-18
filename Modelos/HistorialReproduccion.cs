using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Representa un registro de la tabla historial_reproduccion.
    /// </summary>
    internal class HistorialReproduccion
    {
        public int  idHistorial {  get; set; }
        public int idUsuario { get; set; }
        public int idContenido { get; set; }
        public DateTime Fecha { get; set; }
        public int MinutosVistos { get; set; }

    }
}
