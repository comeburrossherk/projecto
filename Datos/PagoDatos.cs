using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas y cambios a la tabla pagos.
    /// </summary>
    internal class PagoDatos
    {
        /// <summary>
        /// Guarda un pago (simulado). La fecha la pone MySQL automáticamente.
        /// </summary>
        public void Registrar(Pago pago)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "INSERT INTO pagos (id_suscripcion, monto, metodo, concepto) " +
                             "VALUES (@suscripcion, @monto, @metodo, @concepto)";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@suscripcion", pago.idSuscripcion);
                cone.Parameters.AddWithValue("@monto", pago.Monto);
                cone.Parameters.AddWithValue("@metodo", pago.Metodo);
                cone.Parameters.AddWithValue("@concepto", pago.Concepto);

                cone.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Regresa todos los pagos de un usuario, del más reciente al más antiguo.
        /// </summary>
        public List<Pago> ObtenerPorUsuario(int idUsuario)
        {
            List<Pago> lista = new List<Pago>();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT p.* FROM pagos p " +
                             "JOIN suscripciones s ON s.id_suscripcion = p.id_suscripcion " +
                             "WHERE s.id_usuario = @id ORDER BY p.fecha_pago DESC";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@id", idUsuario);
                MySqlDataReader lector = cone.ExecuteReader();

                while (lector.Read())
                {
                    Pago pago = new Pago();
                    pago.idPago = Convert.ToInt32(lector["id_pago"]);
                    pago.idSuscripcion = Convert.ToInt32(lector["id_suscripcion"]);
                    pago.Monto = Convert.ToDecimal(lector["monto"]);
                    pago.FechaPago = Convert.ToDateTime(lector["fecha_pago"]);
                    pago.Metodo = lector["metodo"].ToString();
                    pago.Concepto = lector["concepto"].ToString();
                    lista.Add(pago);
                }
            }

            return lista;
        }
    }
}
