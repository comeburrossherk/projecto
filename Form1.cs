using System.Security.Permissions;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Pantalla de inicio, desde aqui se va al login o al registro.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Estilos.Aplicar(this);
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            // cuando se cierre el login vuelve a aparecer esta pantalla
            Principal.FormClosed += (s, args) => this.Show();
            Principal.Show();
            this.Hide();

        }

        private void crearcuenta_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.ShowDialog();
        }

               private void Form1_Load(object sender, EventArgs e)
               {

                   
               }
    }
}
