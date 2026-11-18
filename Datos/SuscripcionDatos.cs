using System;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas y cambios a la tabla suscripciones.
    /// </summary>
    internal class SuscripcionDatos
    {
        /// <summary>
        /// Regresa la suscripción ACTIVA y vigente de un usuario, o null si no tiene.
        /// </summary>
        public Suscripcion ObtenerActiva(int idUsuario)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM suscripciones " +
                             "WHERE id_usuario = @id AND estado = 'ACTIVA' AND fecha_fin >= CURDATE() " +
                             "ORDER BY fecha_fin DESC LIMIT 1";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@id", idUsuario);
                MySqlDataReader lector = cone.ExecuteReader();

                if (lector.Read())
                {
                    Suscripcion sus = new Suscripcion();
                    sus.idSuscripcion = Convert.ToInt32(lector["id_suscripcion"]);
                    sus.idUsuario = Convert.ToInt32(lector["id_usuario"]);
                    sus.idPlan = Convert.ToInt32(lector["id_plan"]);
                    sus.FechaInicio = Convert.ToDateTime(lector["fecha_inicio"]);
                    sus.FechaFin = Convert.ToDateTime(lector["fecha_fin"]);
                    sus.Estado = lector["estado"].ToString();
                    sus.FueRecomendado = Convert.ToBoolean(lector["fue_recomendado"]);
                    return sus;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Guarda una suscripción nueva y regresa el id que le asignó MySQL.
        /// </summary>
        public int Crear(Suscripcion sus)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "INSERT INTO suscripciones (id_usuario, id_plan, fecha_inicio, fecha_fin, estado, fue_recomendado) " +
                             "VALUES (@usuario, @plan, @inicio, @fin, @estado, @recomendado)";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@usuario", sus.idUsuario);
                cone.Parameters.AddWithValue("@plan", sus.idPlan);
                cone.Parameters.AddWithValue("@inicio", sus.FechaInicio);
                cone.Parameters.AddWithValue("@fin", sus.FechaFin);
                cone.Parameters.AddWithValue("@estado", sus.Estado);
                cone.Parameters.AddWithValue("@recomendado", sus.FueRecomendado);

                cone.ExecuteNonQuery();

                int idNuevo = Convert.ToInt32(cone.LastInsertedId);
                return idNuevo;
            }
        }

        /// <summary>
        /// Alarga la fecha de fin de una suscripción (renovación).
        /// </summary>
        public void Renovar(int idSuscripcion, DateTime nuevaFechaFin)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "UPDATE suscripciones SET fecha_fin = @fin WHERE id_suscripcion = @id";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@fin", nuevaFechaFin);
                cone.Parameters.AddWithValue("@id", idSuscripcion);

                cone.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Cambia el estado de una suscripcion, por ejemplo a CANCELADA o CAMBIO DE PLAN.
        /// </summary>
        public void CambiarEstado(int idSuscripcion, string nuevoEstado)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "UPDATE suscripciones SET estado = @estado WHERE id_suscripcion = @id";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@estado", nuevoEstado);
                cone.Parameters.AddWithValue("@id", idSuscripcion);

                cone.ExecuteNonQuery();
            }
        }
    }
}
