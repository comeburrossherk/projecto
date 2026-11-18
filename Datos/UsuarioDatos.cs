using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1.Datos
{
    /// <summary>
    /// Consultas y registros de la tabla usuarios.
    /// </summary>
    internal class UsuarioDatos
    {
        /// <summary>
        /// Revisa si ya hay un usuario registrado con ese correo.
        /// </summary>
        public bool ExisteCorreo(string correo)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE correo = @correo";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@correo", correo);

                int cantidad = Convert.ToInt32(cone.ExecuteScalar());
                if (cantidad > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Guarda un usuario nuevo y regresa el id que le dio MySQL.
        /// </summary>
        public int Registrar(Usuario usuario)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "INSERT INTO usuarios (nombre, apellidos, correo, telefono, sexo, " +
                    " contraseña, fecha_nacimiento, ocupacion, matricula, " +
                    "ingreso_mensual, personas_hogar) " +
                    "VALUES (@nombre, @apellido, @correo, @telefono, @sexo, @contraseña, @fecha, " +
                    "@ocupacion, @matricula, @ingreso, @personas)";

                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cone.Parameters.AddWithValue("@apellido", usuario.Apellido);
                cone.Parameters.AddWithValue("@correo", usuario.Correo);
                cone.Parameters.AddWithValue("@telefono", usuario.Telefono);
                cone.Parameters.AddWithValue("@sexo", usuario.Sexo);
                cone.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                cone.Parameters.AddWithValue("@fecha", usuario.FechaNacimiento);
                cone.Parameters.AddWithValue("@ocupacion", usuario.Ocupacion);


                // si no es estudiante la matricula va como NULL
                if (usuario.Matricula == "")
                {
                    cone.Parameters.AddWithValue("@matricula", DBNull.Value);
                }
                else
                {
                    cone.Parameters.AddWithValue("@matricula", usuario.Matricula);

                }
                cone.Parameters.AddWithValue("@ingreso", usuario.IngresoMensual);
                cone.Parameters.AddWithValue("@personas", usuario.PersonasHogar);

                cone.ExecuteNonQuery();

                int idNuevo = Convert.ToInt32(cone.LastInsertedId);
                return idNuevo;

            }
        }
             /// <summary>
             /// Busca un usuario por correo y contraseña.
             /// Regresa un Cliente o un Administrador según su rol, o null si los datos son incorrectos.
             /// </summary>
        public Usuario IniciarSesion(string correo, string contraseña)
        {
            using (MySqlConnection con = Conexion.Obtener())
            {
                con.Open();
                string sql = "SELECT * FROM usuarios WHERE correo = @correo AND contraseña = @contraseña";
                MySqlCommand cone = new MySqlCommand(sql, con);
                cone.Parameters.AddWithValue("@correo", correo);
                cone.Parameters.AddWithValue("@contraseña", contraseña);

                MySqlDataReader lector = cone.ExecuteReader();

                if (lector.Read())
                {
                    Usuario usuario;
                    string rol = lector["rol"].ToString();

                    // se crea Administrador o Cliente segun el rol pero se guarda como Usuario
                    if (rol == "ADMIN")
                    {
                        usuario = new Administrador();
                    }
                    else
                    {
                        usuario = new Cliente();
                    }

                    usuario.idUsuario = Convert.ToInt32(lector["id_usuario"]);
                    usuario.Nombre = lector["nombre"].ToString();
                    usuario.Apellido = lector["apellidos"].ToString();
                    usuario.Correo = lector["correo"].ToString();
                    usuario.Telefono = lector["telefono"].ToString();
                    usuario.Sexo = lector["sexo"].ToString();
                    usuario.Contraseña = lector["contraseña"].ToString();
                    usuario.FechaNacimiento = Convert.ToDateTime(lector["fecha_nacimiento"]);
                    usuario.Ocupacion = lector["ocupacion"].ToString();

                    if (lector.IsDBNull(lector.GetOrdinal("matricula")))
                    {
                        usuario.Matricula = "";
                    }
                    else
                    {
                        usuario.Matricula = lector["matricula"].ToString();
                    }

                    usuario.IngresoMensual = Convert.ToDecimal(lector["ingreso_mensual"]);
                    usuario.PersonasHogar = Convert.ToInt32(lector["personas_hogar"]);
                    usuario.FechaRegistro = Convert.ToDateTime(lector["fecha_registro"]);

                    return usuario;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
