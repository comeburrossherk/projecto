using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Representa un plan de suscripcion de la tabla planes.
    /// </summary>
    public class Plan
    {
        public int idPlan { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioMensual { get; set; }
        public int Nivel { get; set; }
        public string Calidad { get; set; }
        public int Pantallas { get; set; }
        public bool ConAnuncios { get; set; }
        public string Requisito { get; set; }
        public bool Activo { get; set; }
    }
}
