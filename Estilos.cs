using System.Drawing;
using System.Windows.Forms;

namespace suscripciones_proyecto_intento1
{
    /// <summary>
    /// Colores y letra de todo el programa. Cada formulario llama a Aplicar en su constructor
    /// para que todas las pantallas se vean igual.
    /// </summary>
    public static class Estilos
    {
        public static Color Fondo = Color.FromArgb(18, 18, 24);
        public static Color FondoCampos = Color.FromArgb(38, 38, 48);
        public static Color Texto = Color.White;
        public static Color TextoSuave = Color.FromArgb(180, 180, 195);
        public static Color Acento = Color.FromArgb(124, 58, 237);
        public static Font Letra = new Font("Segoe UI", 10);

        /// <summary>
        /// Le pone los colores y la letra al formulario y a todos sus controles.
        /// </summary>
        public static void Aplicar(Form formulario)
        {
            formulario.BackColor = Fondo;
            formulario.ForeColor = Texto;
            formulario.Font = Letra;

            AplicarControles(formulario.Controls);
        }

        /// <summary>
        /// Recorre los controles y les da estilo segun su tipo.
        /// Si un control tiene otros adentro (un Panel o GroupBox) tambien los recorre.
        /// </summary>
        private static void AplicarControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.BackColor = Acento;
                    boton.ForeColor = Texto;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Cursor = Cursors.Hand;
                }
                else if (control is ComboBox)
                {
                    ComboBox lista = (ComboBox)control;
                    lista.BackColor = FondoCampos;
                    lista.ForeColor = Texto;
                    lista.FlatStyle = FlatStyle.Flat;
                }
                else if (control is TextBox || control is NumericUpDown)
                {
                    control.BackColor = FondoCampos;
                    control.ForeColor = Texto;
                }
                else if (control is DataGridView)
                {
                    DataGridView tabla = (DataGridView)control;
                    tabla.BackgroundColor = FondoCampos;
                    tabla.GridColor = Fondo;
                    tabla.BorderStyle = BorderStyle.None;
                    tabla.EnableHeadersVisualStyles = false;
                    tabla.ColumnHeadersDefaultCellStyle.BackColor = Acento;
                    tabla.ColumnHeadersDefaultCellStyle.ForeColor = Texto;
                    tabla.DefaultCellStyle.BackColor = FondoCampos;
                    tabla.DefaultCellStyle.ForeColor = Texto;
                    tabla.DefaultCellStyle.SelectionBackColor = Acento;
                    tabla.DefaultCellStyle.SelectionForeColor = Texto;
                    tabla.RowHeadersDefaultCellStyle.BackColor = FondoCampos;
                }
                else if (control is ListBox)
                {
                    control.BackColor = FondoCampos;
                    control.ForeColor = Texto;
                }
                else
                {
                    control.ForeColor = Texto;
                }

                if (control.Controls.Count > 0)
                {
                    AplicarControles(control.Controls);
                }
            }
        }
    }
}
