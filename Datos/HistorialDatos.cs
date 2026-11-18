using System;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas y cambios a la tabla historial_reproduccion.
    /// </summary>
    internal class HistorialDatos
    {
        /// <summary>
        /// Guarda que un usuario vio un contenido.
        /// </summary>
        public void Registrar(HistorialReproduccion historial)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "INSERT INTO historial_reproduccion (id_usuario, id_contenido, minutos_vistos) " +
                             "VALUES (@usuario, @contenido, @minutos)";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@usuario", historial.idUsuario);
                cone.Parameters.AddWithValue("@contenido", historial.idContenido);
                cone.Parameters.AddWithValue("@minutos", historial.MinutosVistos);

                cone.ExecuteNonQuery();
            }
        }
    }
}
