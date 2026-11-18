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
    /// Recomienda un plan según los datos del cliente y le permite contratarlo.
    /// </summary>
    public partial class FrmRecomendador2 : Form
    {
        private List<Plan> planes;
        private Plan planRecomendado;
        public FrmRecomendador2()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }
        /// <summary>
        /// Calcula la edad del usuario que inicio sesion.
        /// </summary>
        private int CalcularEdad()
        {
            DateTime fechaNacimiento = Sesion.UsuarioActual.FechaNacimiento;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad = edad - 1;
            }

            return edad;
        }
        /// <summary>
        /// Decide que plan recomendar segun los datos del usuario, lo muestra y lo selecciona en la tabla.
        /// </summary>
        private void MostrarRecomendacion()
        {
            Usuario usuario = Sesion.UsuarioActual;
            int edad = CalcularEdad();
            string nombrePlan;
            string razon;
            // el orden de los if importa, el primero que se cumpla es el que se recomienda
            if (chk4K.Checked)
            {
                nombrePlan = "Premium";
                razon = "es el único plan con calidad 4K.";
            }
            else if (usuario.Ocupacion == "ESTUDIANTE")
            {
                nombrePlan = "Estudiante";
                razon = "tienes precio especial por ser estudiante.";
            }
            else if (edad >= 60 || usuario.Ocupacion == "JUBILADO")
            {
                nombrePlan = "Plata";
                razon = "es el plan especial para adultos mayores.";
            }
            else if (usuario.PersonasHogar >= 3)
            {
                nombrePlan = "Premium";
                razon = "permite 4 pantallas a la vez para tu familia.";
            }
            else if (usuario.PersonasHogar == 2)
            {
                nombrePlan = "Estándar";
                razon = "permite 2 pantallas a la vez.";
            }
            else if (usuario.IngresoMensual < 5000)
            {
                nombrePlan = "Básico";
                razon = "es el más económico.";
            }
            else
            {
                nombrePlan = "Estándar";
                razon = "tiene buena calidad y sin anuncios.";
            }

            foreach (Plan plan in planes)
            {
                if (plan.Nombre == nombrePlan)
                {
                    planRecomendado = plan;
                }
            }

            lblRecomendacion.Text = "Te recomendamos el plan " + nombrePlan + " porque " + razon;

            // marcar en la tabla el plan recomendado
            foreach (DataGridViewRow fila in dgvPlanes.Rows)
            {
                if (fila.Cells["Nombre"].Value.ToString() == nombrePlan)
                {
                    fila.Selected = true;
                    dgvPlanes.CurrentCell = fila.Cells["Nombre"];
                }
            }
        }

        private void FrmRecomendador2_Load(object sender, EventArgs e)
        {
            try
            {
                PlanDatos datos = new PlanDatos();
                planes = datos.ObtenerPlanes();

                dgvPlanes.DataSource = planes;
                dgvPlanes.Columns["idPlan"].Visible = false;
                dgvPlanes.Columns["Activo"].Visible = false;

                cmbMetodo.Items.Add("TARJETA");
                cmbMetodo.Items.Add("PAYPAL");
                cmbMetodo.Items.Add("OXXO");

                MostrarRecomendacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los planes: " + ex.Message);
            }
        }

        private void chk4K_CheckedChanged(object sender, EventArgs e)
        {
            MostrarRecomendacion();
        }

        /// <summary>
        /// Crea la suscripcion y el pago del plan elegido.
        /// </summary>
        private void btnContratar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un plan.");
                return;
            }

            if (cmbMetodo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un método de pago.");
                return;
            }

            Plan elegido = (Plan)dgvPlanes.CurrentRow.DataBoundItem;
            Usuario usuario = Sesion.UsuarioActual;

            // puede elegir otro plan pero no uno al que no tiene derecho
            if (elegido.Requisito == "ESTUDIANTE" && usuario.Ocupacion != "ESTUDIANTE")
            {
                MessageBox.Show("El plan Estudiante es solo para estudiantes.");
                return;
            }

            if (elegido.Requisito == "ADULTO MAYOR" && CalcularEdad() < 60)
            {
                MessageBox.Show("El plan Plata es solo para mayores de 60 años.");
                return;
            }

            Suscripcion sus = new Suscripcion();
            sus.idUsuario = usuario.idUsuario;
            sus.idPlan = elegido.idPlan;
            sus.FechaInicio = DateTime.Today;
            sus.FechaFin = DateTime.Today.AddMonths(1);
            sus.Estado = "ACTIVA";

            // para saber si hizo caso a la recomendacion
            if (planRecomendado != null && elegido.idPlan == planRecomendado.idPlan)
            {
                sus.FueRecomendado = true;
            }
            else
            {
                sus.FueRecomendado = false;
            }

            try
            {
                SuscripcionDatos susDatos = new SuscripcionDatos();
                int idSuscripcion = susDatos.Crear(sus);

                Pago pago = new Pago();
                pago.idSuscripcion = idSuscripcion;
                pago.Monto = elegido.PrecioMensual;
                pago.Metodo = cmbMetodo.SelectedItem.ToString();
                pago.Concepto = "Nueva suscripción - " + elegido.Nombre;

                PagoDatos pagoDatos = new PagoDatos();
                pagoDatos.Registrar(pago);

                MessageBox.Show("¡Listo! Contrataste el plan " + elegido.Nombre +
                                " por $" + elegido.PrecioMensual + " al mes.");

                // asi la pantalla que lo abrio sabe que si contrato
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contratar: " + ex.Message);
            }
        }
    }
}
