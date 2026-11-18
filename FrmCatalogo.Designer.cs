namespace suscripciones_proyecto_intento1
{
    partial class FrmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            dgvCatalogo = new DataGridView();
            btnReproducir = new Button();
            btnMiSuscripcion = new Button();
            btnCerrarSesion = new Button();
            picPortada = new PictureBox();
            label1 = new Label();
            lstRecomendados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.Location = new Point(76, 6);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(712, 49);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "";
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(420, 58);
            dgvCatalogo.MultiSelect = false;
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.RowHeadersWidth = 51;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.Size = new Size(742, 317);
            dgvCatalogo.TabIndex = 1;
            dgvCatalogo.SelectionChanged += dgvCatalogo_SelectionChanged;
            // 
            // btnReproducir
            // 
            btnReproducir.Location = new Point(27, 151);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(116, 43);
            btnReproducir.TabIndex = 2;
            btnReproducir.Text = "Reproducir";
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnMiSuscripcion
            // 
            btnMiSuscripcion.Location = new Point(27, 220);
            btnMiSuscripcion.Name = "btnMiSuscripcion";
            btnMiSuscripcion.Size = new Size(134, 61);
            btnMiSuscripcion.TabIndex = 3;
            btnMiSuscripcion.Text = "Mi suscripción";
            btnMiSuscripcion.UseVisualStyleBackColor = true;
            btnMiSuscripcion.Click += btnMiSuscripcion_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(993, 524);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(119, 29);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // picPortada
            // 
            picPortada.Location = new Point(12, 325);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(377, 285);
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            picPortada.TabIndex = 6;
            picPortada.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 415);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 7;
            label1.Text = "Recomendado para ti";
            // 
            // lstRecomendados
            // 
            lstRecomendados.FormattingEnabled = true;
            lstRecomendados.Location = new Point(488, 438);
            lstRecomendados.Name = "lstRecomendados";
            lstRecomendados.Size = new Size(234, 164);
            lstRecomendados.TabIndex = 8;
            // 
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 640);
            Controls.Add(lstRecomendados);
            Controls.Add(label1);
            Controls.Add(picPortada);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnMiSuscripcion);
            Controls.Add(btnReproducir);
            Controls.Add(dgvCatalogo);
            Controls.Add(lblBienvenida);
            Name = "FrmCatalogo";
            Text = "NovaStream";
            Load += FrmCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private DataGridView dgvCatalogo;
        private Button btnReproducir;
        private Button btnMiSuscripcion;
        private Button btnCerrarSesion;
        private PictureBox picPortada;
        private Label label1;
        private ListBox lstRecomendados;
    }
}