using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using suscripciones_proyecto_intento1.Datos;
using suscripciones_proyecto_intento1.Modelos;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Formulario para crear una cuenta nueva de cliente.
    /// </summary>
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("MASCULINO");
            cmbSexo.Items.Add("FEMENINO");
            cmbSexo.Items.Add("OTRO");
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOcupacion.Items.Add("ESTUDIANTE");
            cmbOcupacion.Items.Add("EMPLEADO");
            cmbOcupacion.Items.Add("INDEPENDIENTE");
            cmbOcupacion.Items.Add("JUBILADO");
            cmbOcupacion.Items.Add("DESEMPLEADO");
            cmbOcupacion.Items.Add("OTRO");
            cmbOcupacion.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMatricula.Enabled = false;

        }

        /// <summary>
        /// Activa la matricula solo si la ocupacion es ESTUDIANTE.
        /// </summary>
        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esEstudiante = false;
            if (cmbOcupacion.SelectedItem != null)
            {
                string respuesta = cmbOcupacion.SelectedItem.ToString();
                if (respuesta == "ESTUDIANTE")
                {
                    esEstudiante = true;
                }
            }
            // solo los estudiantes llenan la matricula
            if (esEstudiante)
            {
                txtMatricula.Enabled = true;
            }
            else
            {
                txtMatricula.Enabled = false;
                txtMatricula.Text = "";

            }

        }

        /// <summary>
        /// Valida los datos del formulario y guarda al nuevo cliente en la base de datos.
        /// </summary>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // validaciones antes de guardar
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtContraseña.Text == "" || txtConfirmar.Text == "" ||
                    txtCorreo.Text == "" || txtNumero.Text == "" )
            {
                MessageBox.Show("llena todos los puntos antes de continuar");
                return;
            }
            if (cmbOcupacion.SelectedItem == null || cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("llena todos los puntos antes de continuar");
                return;
            }
            if (txtCorreo.Text.Contains("@") == false)
            {
                MessageBox.Show("selecciona un correo valido");
                return;
            }
            if (txtNumero.Text.Length !=10)
            {
                MessageBox.Show("ingresa un telefono valido");
                return;
            }
            if (txtContraseña.Text.Length <6)
            {
                MessageBox.Show("la contraseña es demaciado corta");
                return;
            }
            if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("tu contraseña no coincide");
                return;
            }
            string ocupacion = cmbOcupacion.SelectedItem.ToString();
            if (ocupacion == "ESTUDIANTE" && txtMatricula.Text == "")
            {
                MessageBox.Show("debes poner tu matricula");
                return;
            }
            // sacar la edad, si no ha cumplido años este año se le resta 1
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad = edad - 1;
            }

            if (edad <13)
            {
                MessageBox.Show("no tienes edad para crear una cuenta");
                return;
            }
            // el ingreso es opcional, si lo dejan vacio se queda en 0
            decimal ingreso = 0;
            if (txtIngreso.Text != "")
            {
                bool esNumero = decimal.TryParse(txtIngreso.Text, out ingreso);

                if (esNumero == false)
                {
                    MessageBox.Show("Los ingresos deben ser un número.");
                    return;
                }
            }
            // no se puede repetir el correo
            UsuarioDatos datos = new UsuarioDatos();
            if (datos.ExisteCorreo(txtCorreo.Text)) 
            {
                MessageBox.Show("ya existe un usuario con este correo");
                return;
            }
            // el que se registra siempre es cliente
            Cliente nuevo = new Cliente();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Correo = txtCorreo.Text;
            nuevo.Contraseña = txtContraseña.Text;
            nuevo.Telefono = txtNumero.Text;
            nuevo.Sexo = cmbSexo.SelectedItem.ToString();
            nuevo.FechaNacimiento = fechaNacimiento;
            nuevo.Ocupacion = ocupacion;
            nuevo.Matricula = txtMatricula.Text;
            nuevo.IngresoMensual = ingreso;
            nuevo.PersonasHogar = Convert.ToInt32(nupPersonas.Value);


            try
            {
                int idNuevo = datos.Registrar(nuevo);
                MessageBox.Show("¡Cuenta creada con éxito! Tu número de usuario es " + idNuevo);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
    }
    
}
