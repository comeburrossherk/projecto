using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using suscripciones_proyecto_intento1.Datos;
using suscripciones_proyecto_intento1.Modelos;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Panel del administrador para agregar, editar y eliminar contenido del catalogo.
    /// </summary>
    public partial class FrmAdmin : Form
    {
        private int idSeleccionado = 0;

        public FrmAdmin()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }


        /// <summary>
        /// Llena la tabla con todo el catálogo.
        /// </summary>
        private void CargarContenidos()
        {
            ContenidoDatos datos = new ContenidoDatos();
            dgvContenidos.DataSource = datos.ObtenerTodos();
            dgvContenidos.Columns["idContenido"].Visible = false;
            dgvContenidos.Columns["DuracionMin"].Visible = false;
            dgvContenidos.Columns["Sinopsis"].Visible = false;
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("pelicula");
            cmbTipo.Items.Add("serie");
            cmbTipo.Items.Add("documental");

            cmbClasificacion.Items.Add("AA");
            cmbClasificacion.Items.Add("A");
            cmbClasificacion.Items.Add("B");
            cmbClasificacion.Items.Add("B15");
            cmbClasificacion.Items.Add("C");
            cmbClasificacion.Items.Add("D");

            try
            {
                CargarContenidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }

        /// <summary>
        /// Al dar clic en una fila pasa sus datos a los campos para poder editarla o eliminarla.
        /// </summary>
        private void dgvContenidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // si dan clic en el encabezado no hay fila
            if (e.RowIndex < 0)
            {
                return;
            }

            Contenido contenido = (Contenido)dgvContenidos.Rows[e.RowIndex].DataBoundItem;

            txtTitulo.Text = contenido.Titulo;
            cmbTipo.SelectedItem = contenido.Tipo;
            txtGenero.Text = contenido.Genero;
            nudAño.Value = contenido.Año;
            nudDuracion.Value = contenido.DuracionMin;
            cmbClasificacion.SelectedItem = contenido.Clasificacion;
            nudNivel.Value = contenido.NivelMinimo;
            txtSinopsis.Text = contenido.Sinopsis;

            idSeleccionado = contenido.idContenido;
        }

        /// <summary>
        /// Revisa que los campos obligatorios estén llenos.
        /// </summary>
        private bool ValidarCampos()
        {
            if (txtTitulo.Text == "" || txtGenero.Text == "" || txtSinopsis.Text == "")
            {
                MessageBox.Show("Llena título, género y sinopsis.");
                return false;
            }

            if (cmbTipo.SelectedItem == null || cmbClasificacion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona el tipo y la clasificación.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Crea una Pelicula, Serie o Documental con los datos escritos en el formulario.
        /// </summary>
        private Contenido CrearDesdeFormulario()
        {
            Contenido contenido;
            string tipo = cmbTipo.SelectedItem.ToString();

            // Contenido es abstracta asi que se crea el tipo que eligieron
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

            contenido.Titulo = txtTitulo.Text;
            contenido.Genero = txtGenero.Text;
            contenido.Año = Convert.ToInt32(nudAño.Value);
            contenido.DuracionMin = Convert.ToInt32(nudDuracion.Value);
            contenido.Clasificacion = cmbClasificacion.SelectedItem.ToString();
            contenido.NivelMinimo = Convert.ToInt32(nudNivel.Value);
            contenido.Sinopsis = txtSinopsis.Text;

            return contenido;
        }

        /// <summary>
        /// Deja los campos vacíos y quita la selección.
        /// </summary>
        private void Limpiar()
        {
            txtTitulo.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtGenero.Text = "";
            nudAño.Value = DateTime.Today.Year;
            nudDuracion.Value = 1;
            cmbClasificacion.SelectedIndex = -1;
            nudNivel.Value = 1;
            txtSinopsis.Text = "";
            idSeleccionado = 0;
            dgvContenidos.ClearSelection();
        }

        /// <summary>
        /// Agrega un contenido nuevo con lo que se escribio en los campos.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }

            try
            {
                Contenido nuevo = CrearDesdeFormulario();
                ContenidoDatos datos = new ContenidoDatos();
                datos.Agregar(nuevo);

                MessageBox.Show("Contenido agregado.");
                CargarContenidos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        /// <summary>
        /// Guarda los cambios del contenido seleccionado.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 0 quiere decir que no han seleccionado nada
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un contenido de la tabla.");
                return;
            }

            if (ValidarCampos() == false)
            {
                return;
            }

            try
            {
                Contenido editado = CrearDesdeFormulario();
                editado.idContenido = idSeleccionado;

                ContenidoDatos datos = new ContenidoDatos();
                datos.Editar(editado);

                MessageBox.Show("Contenido actualizado.");
                CargarContenidos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina el contenido seleccionado despues de confirmar.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un contenido de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar \"" + txtTitulo.Text + "\"? También se borrará su historial.",
                                                     "Eliminar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                ContenidoDatos datos = new ContenidoDatos();
                datos.Eliminar(idSeleccionado);

                MessageBox.Show("Contenido eliminado.");
                CargarContenidos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Sesion.UsuarioActual = null;
            this.Close();
        }

        /// <summary>
        /// Abre la pantalla de estadisticas.
        /// </summary>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas estadisticas = new FrmEstadisticas();
            estadisticas.ShowDialog();
        }
    }
}
