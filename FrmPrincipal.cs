using suscripciones_proyecto_intento1.Datos;
using suscripciones_proyecto_intento1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Pantalla de inicio de sesion.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }
        /// <summary>
        /// Valida el correo y la contraseña, guarda la sesion y manda al usuario a su pantalla segun su rol.
        /// </summary>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Escribe tu correo y tu contraseña.");
                return;
            }

            UsuarioDatos datos = new UsuarioDatos();
            Usuario usuario = null;

            try
            {
                usuario = datos.IniciarSesion(txtCorreo.Text, txtContraseña.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return;
            }

            if (usuario == null)
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
                return;
            }

            // se guarda el usuario para usarlo en las demas pantallas
            Sesion.UsuarioActual = usuario;

            // cada tipo de usuario tiene su propio mensaje (override)
            MessageBox.Show(usuario.ObtenerBienvenida());


            if (usuario.Rol == "CLIENTE")
            {
                SuscripcionDatos susDatos = new SuscripcionDatos();
                Suscripcion activa = susDatos.ObtenerActiva(usuario.idUsuario);

                // si no tiene plan primero tiene que elegir uno
                if (activa == null)
                {
                    FrmRecomendador2 recomendador = new FrmRecomendador2();
                    recomendador.ShowDialog();
                    activa = susDatos.ObtenerActiva(usuario.idUsuario);
                }

                if (activa == null)
                {
                    MessageBox.Show("Necesitas contratar un plan para ver el catálogo.");
                    return;
                }

                FrmCatalogo catalogo = new FrmCatalogo();
                // se esconde el login mientras esta abierto el catalogo
                this.Hide();
                catalogo.ShowDialog();
                this.Close();
            }
            else if (usuario.Rol == "ADMIN")
            {
                FrmAdmin admin = new FrmAdmin();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }

        }

        private void btnOlvide_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Contacta al administrador para recuperar tu contraseña.");
        }
    }
}
