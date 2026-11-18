using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas a la tabla contenidos.
    /// </summary>
    internal class ContenidoDatos
    {
        /// <summary>
        /// Regresa el contenido que se puede ver con un nivel de plan (1 Básico, 2 Estándar, 3 Premium).
        /// </summary>
        public List<Contenido> ObtenerPorNivel(int nivel)
        {
            List<Contenido> lista = new List<Contenido>();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM contenidos WHERE nivel_minimo <= @nivel ORDER BY titulo";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@nivel", nivel);
                MySqlDataReader lector = cone.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(LeerContenido(lector));
                }
            }

            return lista;
        }

        /// <summary>
        /// Regresa todo el catálogo sin importar el nivel.
        /// </summary>
        public List<Contenido> ObtenerTodos()
        {
            List<Contenido> lista = new List<Contenido>();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM contenidos ORDER BY titulo";
                MySqlCommand cone = new MySqlCommand(sql, con);
                MySqlDataReader lector = cone.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(LeerContenido(lector));
                }
            }

            return lista;
        }
        /// <summary>
        /// Recomienda hasta 5 titulos del genero que mas ve el usuario y que todavia no ha visto.
        /// Solo regresa contenido que su plan puede ver.
        /// </summary>
        public List<Contenido> ObtenerRecomendados(int idUsuario, int nivel)
        {
            List<Contenido> lista = new List<Contenido>();

            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                // la subconsulta saca el genero que mas ha visto el usuario
                string sql = "SELECT * FROM contenidos " +
                             "WHERE nivel_minimo <= @nivel " +
                             "AND genero = (SELECT c.genero FROM historial_reproduccion h " +
                             "JOIN contenidos c ON c.id_contenido = h.id_contenido " +
                             "WHERE h.id_usuario = @usuario " +
                             "GROUP BY c.genero ORDER BY COUNT(*) DESC LIMIT 1) " +
                             "AND id_contenido NOT IN (SELECT id_contenido FROM historial_reproduccion WHERE id_usuario = @usuario) " +
                             "ORDER BY titulo LIMIT 5";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@nivel", nivel);
                cone.Parameters.AddWithValue("@usuario", idUsuario);
                MySqlDataReader lector = cone.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(LeerContenido(lector));
                }
            }

            return lista;
        }

        /// <summary>
        /// Agrega un contenido nuevo al catálogo.
        /// </summary>
        public void Agregar(Contenido contenido)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "INSERT INTO contenidos (titulo, tipo, genero, año, duracion_min, clasificacion, sinopsis, nivel_minimo) " +
                             "VALUES (@titulo, @tipo, @genero, @año, @duracion, @clasificacion, @sinopsis, @nivel)";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@titulo", contenido.Titulo);
                cone.Parameters.AddWithValue("@tipo", contenido.Tipo);
                cone.Parameters.AddWithValue("@genero", contenido.Genero);
                cone.Parameters.AddWithValue("@año", contenido.Año);
                cone.Parameters.AddWithValue("@duracion", contenido.DuracionMin);
                cone.Parameters.AddWithValue("@clasificacion", contenido.Clasificacion);
                cone.Parameters.AddWithValue("@sinopsis", contenido.Sinopsis);
                cone.Parameters.AddWithValue("@nivel", contenido.NivelMinimo);

                cone.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Modifica los datos de un contenido existente.
        /// </summary>
        public void Editar(Contenido contenido)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "UPDATE contenidos SET titulo = @titulo, tipo = @tipo, genero = @genero, año = @año, " +
                             "duracion_min = @duracion, clasificacion = @clasificacion, sinopsis = @sinopsis, " +
                             "nivel_minimo = @nivel WHERE id_contenido = @id";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@titulo", contenido.Titulo);
                cone.Parameters.AddWithValue("@tipo", contenido.Tipo);
                cone.Parameters.AddWithValue("@genero", contenido.Genero);
                cone.Parameters.AddWithValue("@año", contenido.Año);
                cone.Parameters.AddWithValue("@duracion", contenido.DuracionMin);
                cone.Parameters.AddWithValue("@clasificacion", contenido.Clasificacion);
                cone.Parameters.AddWithValue("@sinopsis", contenido.Sinopsis);
                cone.Parameters.AddWithValue("@nivel", contenido.NivelMinimo);
                cone.Parameters.AddWithValue("@id", contenido.idContenido);

                cone.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina un contenido y su historial de reproducción.
        /// </summary>
        public void Eliminar(int idContenido)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();

                // primero se borra el historial porque tiene llave foranea a contenidos
                string sqlHistorial = "DELETE FROM historial_reproduccion WHERE id_contenido = @id";
                MySqlCommand cmdHistorial = new MySqlCommand(sqlHistorial, con);
                cmdHistorial.Parameters.AddWithValue("@id", idContenido);
                cmdHistorial.ExecuteNonQuery();

                string sqlContenido = "DELETE FROM contenidos WHERE id_contenido = @id";
                MySqlCommand cmdContenido = new MySqlCommand(sqlContenido, con);
                cmdContenido.Parameters.AddWithValue("@id", idContenido);
                cmdContenido.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Crea una Pelicula, Serie o Documental según la columna tipo y la llena con la fila actual.
        /// </summary>
        private Contenido LeerContenido(MySqlDataReader lector)
        {
            Contenido contenido;
            string tipo = lector["tipo"].ToString().ToLower();

            // segun el tipo se crea su clase hija
            if (tipo == "pelicula")
            {
                contenido = new Pelicula();
            }
            else if (tipo == "serie")
            {
                contenido = new Serie();
            }
            else
            {
                contenido = new Documental();
            }

            contenido.idContenido = Convert.ToInt32(lector["id_contenido"]);
            contenido.Titulo = lector["titulo"].ToString();
            contenido.Genero = lector["genero"].ToString();
            contenido.Año = Convert.ToInt32(lector["año"]);
            contenido.DuracionMin = Convert.ToInt32(lector["duracion_min"]);
            contenido.Clasificacion = lector["clasificacion"].ToString();
            contenido.Sinopsis = lector["sinopsis"].ToString();
            contenido.NivelMinimo = Convert.ToInt32(lector["nivel_minimo"]);

            return contenido;
        }
    }
}
