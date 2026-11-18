using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Clase base de todos los usuarios (tabla usuarios). Es abstracta, solo se crean Cliente o Administrador.
    /// </summary>
    public abstract class Usuario
    {
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion {  get; set; }
        public string Matricula { get; set; }
        public decimal IngresoMensual { get; set; }
        public int PersonasHogar { get; set; }
        public string Rol {  get; set; }
        public DateTime FechaRegistro { get; set; }
        /// <summary>
        /// Mensaje de bienvenida al iniciar sesion. Cliente y Administrador lo cambian con override.
        /// </summary>
        public virtual string ObtenerBienvenida()
        {
            return "Bienvenido, " + Nombre;
        }
    }


}
