using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Se encarga de crear la conexion con la base de datos streaming_db.
    /// </summary>
    public static class Conexion
    {

        private static string cadena =
            "Server=localhost;Port=3306;Database=streaming_db;Uid=root;Pwd=root;CharSet=utf8mb4;";
        /// <summary>
        /// Regresa una conexion nueva a MySQL (hay que abrirla con Open).
        /// </summary>
        public static MySqlConnection Obtener()
        {
            return new MySqlConnection(cadena);
        }
    }

}