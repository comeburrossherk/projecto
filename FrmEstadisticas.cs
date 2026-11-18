using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using suscripciones_proyecto_intento1.Datos;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Muestra un resumen de clientes, suscripciones, ingresos y contenido para el administrador.
    /// </summary>
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                EstadisticasDatos datos = new EstadisticasDatos();

                lblClientes.Text = "Clientes registrados: " + datos.ContarClientes();
                lblActivas.Text = "Suscripciones activas: " + datos.ContarSuscripcionesActivas();
                lblIngresos.Text = "Ingresos totales: $" + datos.ObtenerIngresosTotales().ToString("N2");

                dgvPorPlan.DataSource = datos.SuscripcionesPorPlan();
                dgvPorTipo.DataSource = datos.ContenidoPorTipo();
                dgvMasVistos.DataSource = datos.MasVistos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las estadísticas: " + ex.Message);
            }
        }

    }
}
