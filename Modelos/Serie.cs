using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Contenido de tipo serie. Hereda de Contenido.
    /// </summary>
    public class Serie : Contenido
    {
        public Serie()
            {
                Tipo = "serie";
            }

            /// <summary>
            /// Detalle propio de las series.
            /// </summary>
            public override string ObtenerDetalle()
            {
                return "Serie - episodios de " + DuracionMin + " min";
            }
        
    }
}
