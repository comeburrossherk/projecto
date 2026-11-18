using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Representa un pago de la tabla pagos.
    /// </summary>
    public class Pago
    {
        public int idPago { get; set; }
        public int idSuscripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Metodo { get; set; }
        public string Concepto { get; set; }

    }
}
