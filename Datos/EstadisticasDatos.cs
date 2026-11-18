using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas de resumen para el panel del administrador.
    /// </summary>
    internal class EstadisticasDatos
    {
        /// <summary>
        /// Cuántos clientes hay registrados.
        /// </summary>
        public int ContarClientes()
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE rol = 'CLIENTE'";
                MySqlCommand cone = new MySqlCommand(sql, con);
                return Convert.ToInt32(cone.ExecuteScalar());
            }
        }

        /// <summary>
        /// Cuántas suscripciones están activas y sin vencer.
        /// </summary>
        public int ContarSuscripcionesActivas()
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM suscripciones WHERE estado = 'ACTIVA' AND fecha_fin >= CURDATE()";
                MySqlCommand cone = new MySqlCommand(sql, con);
                return Convert.ToInt32(cone.ExecuteScalar());
            }
        }

        /// <summary>
        /// Suma de todos los pagos registrados.
        /// </summary>
        public decimal ObtenerIngresosTotales()
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT IFNULL(SUM(monto), 0) FROM pagos";
                MySqlCommand cone = new MySqlCommand(sql, con);
                return Convert.ToDecimal(cone.ExecuteScalar());
            }
        }

        /// <summary>
        /// Suscripciones vigentes agrupadas por plan (usa la vista vw_suscripciones_vigentes).
        /// </summary>
        public DataTable SuscripcionesPorPlan()
        {
            string sql = "SELECT plan AS Plan, COUNT(*) AS Suscripciones " +
                         "FROM vw_suscripciones_vigentes GROUP BY plan ORDER BY Suscripciones DESC";
            return Consultar(sql);
        }

        /// <summary>
        /// Cantidad de contenido por tipo (película, serie, documental).
        /// </summary>
        public DataTable ContenidoPorTipo()
        {
            string sql = "SELECT tipo AS Tipo, COUNT(*) AS Cantidad FROM contenidos GROUP BY tipo";
            return Consultar(sql);
        }

        /// <summary>
        /// Los 5 títulos con más reproducciones.
        /// </summary>
        public DataTable MasVistos()
        {
            string sql = "SELECT c.titulo AS Titulo, COUNT(*) AS Reproducciones " +
                         "FROM historial_reproduccion h " +
                         "JOIN contenidos c ON c.id_contenido = h.id_contenido " +
                         "GROUP BY c.id_contenido, c.titulo " +
                         "ORDER BY Reproducciones DESC LIMIT 5";
            return Consultar(sql);
        }

        /// <summary>
        /// Ejecuta un SELECT y regresa el resultado como tabla para mostrarlo en un DataGridView.
        /// </summary>
        private DataTable Consultar(string sql)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, con);
                adaptador.Fill(tabla);
            }

            return tabla;
        }
    }
}
