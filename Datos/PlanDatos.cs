using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas a la tabla planes.
    /// </summary>
    internal class PlanDatos
    {
        /// <summary>
        /// Regresa todos los planes activos, ordenados por precio.
        /// </summary>
        public List<Plan> ObtenerPlanes()
        {
            List<Plan> lista = new List<Plan>();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM planes WHERE activo = 1 ORDER BY precio_mensual";
                MySqlCommand cone = new MySqlCommand(sql, con);
                MySqlDataReader lector = cone.ExecuteReader();

                while (lector.Read())
                {
                    Plan plan = LeerPlan(lector);
                    lista.Add(plan);
                }
            }

            return lista;
        }

        /// <summary>
        /// Busca un plan por su id. Regresa null si no existe.
        /// </summary>
        public Plan ObtenerPorId(int idPlan)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM planes WHERE id_plan = @id";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@id", idPlan);
                MySqlDataReader lector = cone.ExecuteReader();

                if (lector.Read())
                {
                    return LeerPlan(lector);
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Convierte la fila actual del lector en un objeto Plan.
        /// </summary>
        private Plan LeerPlan(MySqlDataReader lector)
        {
            Plan plan = new Plan();
            plan.idPlan = Convert.ToInt32(lector["id_plan"]);
            plan.Nombre = lector["nombre"].ToString();
            plan.Descripcion = lector["descripcion"].ToString();
            plan.PrecioMensual = Convert.ToDecimal(lector["precio_mensual"]);
            plan.Nivel = Convert.ToInt32(lector["nivel"]);
            plan.Calidad = lector["calidad"].ToString();
            plan.Pantallas = Convert.ToInt32(lector["pantallas"]);
            plan.ConAnuncios = Convert.ToBoolean(lector["con_anuncios"]);
            plan.Requisito = lector["requisito"].ToString();
            plan.Activo = Convert.ToBoolean(lector["activo"]);
            return plan;
        }
    }
}
