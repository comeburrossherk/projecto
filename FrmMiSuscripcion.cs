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
    /// Muestra la suscripcion del cliente y permite renovarla, cambiar de plan o cancelarla.
    /// </summary>
    public partial class FrmMiSuscripcion : Form
    {
        private Suscripcion suscripcion;
        private Plan plan;

        public FrmMiSuscripcion()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }
        /// <summary>
        /// Carga los datos del plan actual y el historial de pagos del cliente.
        /// </summary>
        private void CargarDatos()
        {
            SuscripcionDatos susDatos = new SuscripcionDatos();
            suscripcion = susDatos.ObtenerActiva(Sesion.UsuarioActual.idUsuario);

            if (suscripcion == null)
            {
                lblPlan.Text = "No tienes una suscripción activa.";
                btnRenovar.Enabled = false;
                btnCambiarPlan.Enabled = false;
                btnCancelar.Enabled = false;
                return;
            }

            PlanDatos planDatos = new PlanDatos();
            plan = planDatos.ObtenerPorId(suscripcion.idPlan);

            lblPlan.Text = "Plan: " + plan.Nombre +
                           "\nPrecio: $" + plan.PrecioMensual + " al mes" +
                           "\nInicio: " + suscripcion.FechaInicio.ToString("dd/MM/yyyy") +
                           "\nVence: " + suscripcion.FechaFin.ToString("dd/MM/yyyy") +
                           "\nEstado: " + suscripcion.Estado;

            PagoDatos pagoDatos = new PagoDatos();
            dgvPagos.DataSource = pagoDatos.ObtenerPorUsuario(Sesion.UsuarioActual.idUsuario);
            dgvPagos.Columns["idPago"].Visible = false;
            dgvPagos.Columns["idSuscripcion"].Visible = false;
        }

        private void FrmMiSuscripcion_Load(object sender, EventArgs e)
        {
            cmbMetodo.Items.Add("TARJETA");
            cmbMetodo.Items.Add("PAYPAL");
            cmbMetodo.Items.Add("OXXO");

            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la suscripción: " + ex.Message);
            }
        }

        /// <summary>
        /// Alarga la suscripcion un mes y registra el pago.
        /// </summary>
        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un método de pago.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Renovar el plan " + plan.Nombre + " por $" +
                                                     plan.PrecioMensual + "?", "Renovar",
                                                     MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                // se le suma un mes a la fecha en que vence
                DateTime nuevaFechaFin = suscripcion.FechaFin.AddMonths(1);

                SuscripcionDatos susDatos = new SuscripcionDatos();
                susDatos.Renovar(suscripcion.idSuscripcion, nuevaFechaFin);

                Pago pago = new Pago();
                pago.idSuscripcion = suscripcion.idSuscripcion;
                pago.Monto = plan.PrecioMensual;
                pago.Metodo = cmbMetodo.SelectedItem.ToString();
                pago.Concepto = "Renovación - " + plan.Nombre;

                PagoDatos pagoDatos = new PagoDatos();
                pagoDatos.Registrar(pago);

                MessageBox.Show("Renovado. Tu plan ahora vence el " + nuevaFechaFin.ToString("dd/MM/yyyy"));
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renovar: " + ex.Message);
            }
        }

        /// <summary>
        /// Abre el recomendador y si el cliente contrata otro plan, el anterior queda como CAMBIO DE PLAN.
        /// </summary>
        private void btnCambiarPlan_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quieres cambiar de plan? Tu plan actual terminará.",
                                                    "Cambiar plan", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            FrmRecomendador2 recomendador = new FrmRecomendador2();

            // solo si contrato otro plan se cierra el anterior
            if (recomendador.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SuscripcionDatos susDatos = new SuscripcionDatos();
                    susDatos.CambiarEstado(suscripcion.idSuscripcion, "CAMBIO DE PLAN");
                    MessageBox.Show("Cambio de plan realizado.");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar de plan: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Cancela la suscripcion y cierra la sesion.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres cancelar tu suscripción?",
                                                    "Cancelar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                SuscripcionDatos susDatos = new SuscripcionDatos();
                susDatos.CambiarEstado(suscripcion.idSuscripcion, "CANCELADA");
                MessageBox.Show("Tu suscripción fue cancelada. Se cerrará tu sesión.");
                Sesion.UsuarioActual = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar: " + ex.Message);
            }
        }
    }
}
