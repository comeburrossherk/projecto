using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Representa una suscripcion de la tabla suscripciones.
    /// </summary>
    public class Suscripcion
    {
        public int idSuscripcion { get; set; }
        public int idUsuario { get; set; }
        public int idPlan { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public bool FueRecomendado { get; set; }
    }
}
