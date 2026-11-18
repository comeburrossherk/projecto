using System;
using System.Collections.Generic;
using System.Text;

namespace suscripciones_proyecto_intento1.Modelos
{
    /// <summary>
    /// Clase base del catalogo (tabla contenidos). Es abstracta, solo se crean Pelicula, Serie o Documental.
    /// </summary>
    public abstract class Contenido
    {
        public int idContenido {  get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public int Año { get; set; }
        public int DuracionMin { get; set; }
        public string Clasificacion {  get; set; }
        public string Sinopsis { get; set; }
        public int NivelMinimo { get; set; }


        /// <summary>
        /// Descripción corta según el tipo de contenido. Cada clase hija la define.
        /// </summary>
        public abstract string ObtenerDetalle();

        /// <summary>
        /// Muestra el detalle en el catálogo.
        /// </summary>
        public string Detalle
        {
            get
            {
                return ObtenerDetalle();
            }
        }
    }
}
