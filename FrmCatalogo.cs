using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using suscripciones_proyecto_intento1.Datos;
using suscripciones_proyecto_intento1.Modelos;
using System.IO;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Pantalla principal del cliente, muestra el catalogo segun el nivel de su plan.
    /// </summary>
    public partial class FrmCatalogo : Form
    {

        private Suscripcion suscripcion;
        private Plan planActual;
        private List<Contenido> catalogo;

        public FrmCatalogo()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }




        /// <summary>
        /// Simula la reproduccion del contenido seleccionado y lo guarda en el historial. Si el plan tiene anuncios primero muestra uno.
        /// </summary>
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow == null)
            {
                MessageBox.Show("Selecciona algo para ver.");
                return;
            }

            Contenido elegido = (Contenido)dgvCatalogo.CurrentRow.DataBoundItem;

            // el plan basico tiene anuncios
            if (planActual.ConAnuncios)
            {
                MessageBox.Show("Este espacio es publicitario. Mejora tu plan para ver sin anuncios.", "Publicidad");
            }

            MessageBox.Show("Reproduciendo: " + elegido.Titulo + "\n\n" + elegido.Sinopsis, elegido.Detalle);

            try
            {
                HistorialReproduccion historial = new HistorialReproduccion();
                historial.idUsuario = Sesion.UsuarioActual.idUsuario;
                historial.idContenido = elegido.idContenido;
                historial.MinutosVistos = elegido.DuracionMin;

                HistorialDatos historialDatos = new HistorialDatos();
                historialDatos.Registrar(historial);

                CargarRecomendaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el historial: " + ex.Message);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Sesion.UsuarioActual = null;
            this.Close();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            CargarCatalogo();
        }

        /// <summary>
        /// Carga el plan del usuario y el contenido que puede ver.
        /// </summary>
        private void CargarCatalogo()
        {
            try
            {
                SuscripcionDatos susDatos = new SuscripcionDatos();
                suscripcion = susDatos.ObtenerActiva(Sesion.UsuarioActual.idUsuario);

                PlanDatos planDatos = new PlanDatos();
                planActual = planDatos.ObtenerPorId(suscripcion.idPlan);

                lblBienvenida.Text = "Hola, " + Sesion.UsuarioActual.Nombre +
                                     " - Plan " + planActual.Nombre +
                                     " - Vence el " + suscripcion.FechaFin.ToString("dd/MM/yyyy");

                ContenidoDatos contenidoDatos = new ContenidoDatos();
                catalogo = contenidoDatos.ObtenerPorNivel(planActual.Nivel);

                dgvCatalogo.DataSource = catalogo;
                dgvCatalogo.Columns["idContenido"].Visible = false;
                dgvCatalogo.Columns["Tipo"].Visible = false;
                dgvCatalogo.Columns["DuracionMin"].Visible = false;
                dgvCatalogo.Columns["NivelMinimo"].Visible = false;
                dgvCatalogo.Columns["Sinopsis"].Visible = false;

                dgvCatalogo.Columns["Sinopsis"].Visible = false;

                CargarRecomendaciones();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }


        /// <summary>
        /// Abre Mi suscripcion y al regresar vuelve a cargar el catalogo por si cambio el plan.
        /// </summary>
        private void btnMiSuscripcion_Click(object sender, EventArgs e)
        {
            FrmMiSuscripcion miSuscripcion = new FrmMiSuscripcion();
            miSuscripcion.ShowDialog();

            // si cancelo la suscripcion la sesion queda en null y se regresa al inicio
            if (Sesion.UsuarioActual == null)
            {
                this.Close();
            }
            else
            {
                CargarCatalogo();
            }
        }
        /// <summary>
        /// Muestra la portada del contenido seleccionado si existe su imagen.
        /// </summary>
        private void MostrarPortada()
        {
            if (dgvCatalogo.CurrentRow == null)
            {
                return;
            }

            Contenido elegido = (Contenido)dgvCatalogo.CurrentRow.DataBoundItem;
            // las imagenes se llaman igual que el id del contenido
            string ruta = Path.Combine(Application.StartupPath, "Imagenes", elegido.idContenido + ".jpg");

            if (File.Exists(ruta))
            {
                picPortada.Image = Image.FromFile(ruta);
            }
            else
            {
                picPortada.Image = null;
            }
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            MostrarPortada();
        }
        /// <summary>
        /// Llena la lista de recomendaciones segun lo que el cliente ha visto.
        /// </summary>
        private void CargarRecomendaciones()
        {
            lstRecomendados.Items.Clear();

            ContenidoDatos datos = new ContenidoDatos();
            List<Contenido> recomendados = datos.ObtenerRecomendados(Sesion.UsuarioActual.idUsuario, planActual.Nivel);

            if (recomendados.Count == 0)
            {
                lstRecomendados.Items.Add("Mira algo para recibir recomendaciones");
            }
            else
            {
                foreach (Contenido contenido in recomendados)
                {
                    lstRecomendados.Items.Add(contenido.Titulo);
                }
            }
        }
    }
}

