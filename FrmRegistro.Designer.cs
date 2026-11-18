namespace suscripciones_proyecto_intento1
{
    partial class FrmRegistro
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtNumero = new TextBox();
            txtIngreso = new TextBox();
            cmbSexo = new ComboBox();
            cmbOcupacion = new ComboBox();
            label10 = new Label();
            txtContraseña = new TextBox();
            txtConfirmar = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnRegistrarse = new Button();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtMatricula = new TextBox();
            nupPersonas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupPersonas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 85);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre y apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 352);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 3;
            label3.Text = "Número telefónico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 280);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 4;
            label4.Text = "Correo electrónico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 431);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 5;
            label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 425);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 6;
            label6.Text = "Sexo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 85);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 7;
            label7.Text = "Ocupación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 257);
            label8.Name = "label8";
            label8.Size = new Size(209, 20);
            label8.TabIndex = 8;
            label8.Text = "Ingresos mensuales (opcional)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 335);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 9;
            label9.Text = "¿Cuántos usarán la cuenta?";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(40, 111);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "nombre:";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(82, 304);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(114, 27);
            txtCorreo.TabIndex = 16;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(82, 373);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 27);
            txtNumero.TabIndex = 17;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(498, 281);
            txtIngreso.Margin = new Padding(3, 4, 3, 4);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(114, 27);
            txtIngreso.TabIndex = 18;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(498, 465);
            cmbSexo.Margin = new Padding(3, 4, 3, 4);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(138, 28);
            cmbSexo.TabIndex = 20;
            // 
            // cmbOcupacion
            // 
            cmbOcupacion.FormattingEnabled = true;
            cmbOcupacion.Location = new Point(495, 111);
            cmbOcupacion.Margin = new Padding(3, 4, 3, 4);
            cmbOcupacion.Name = "cmbOcupacion";
            cmbOcupacion.Size = new Size(138, 28);
            cmbOcupacion.TabIndex = 23;
            cmbOcupacion.SelectedIndexChanged += cmbEstudiante_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(657, 89);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 24;
            label10.Text = "Matrícula";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(81, 175);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 25;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(82, 238);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 26;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 152);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 27;
            label11.Text = "Contraseña";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 215);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 28;
            label12.Text = "Repetir contraseña";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(860, 626);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(133, 45);
            btnRegistrarse.TabIndex = 29;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = SystemColors.InfoText;
            txtApellido.Location = new Point(160, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "apellido:";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 37;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(35, 454);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 38;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(657, 112);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(132, 27);
            txtMatricula.TabIndex = 39;
            // 
            // nupPersonas
            // 
            nupPersonas.Location = new Point(498, 374);
            nupPersonas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupPersonas.Name = "nupPersonas";
            nupPersonas.Size = new Size(150, 27);
            nupPersonas.TabIndex = 40;
            nupPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 851);
            Controls.Add(nupPersonas);
            Controls.Add(txtMatricula);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(btnRegistrarse);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtConfirmar);
            Controls.Add(txtContraseña);
            Controls.Add(label10);
            Controls.Add(cmbOcupacion);
            Controls.Add(cmbSexo);
            Controls.Add(txtIngreso);
            Controls.Add(txtNumero);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistro";
            Text = "Crear cuenta";
            Load += FrmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)nupPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtNumero;
        private TextBox txtIngreso;
        private ComboBox cmbSexo;
        private ComboBox cmbOcupacion;
        private Label label10;
        private TextBox txtContraseña;
        private TextBox txtConfirmar;
        private Label label11;
        private Label label12;
        private Button btnRegistrarse;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtMatricula;
        private NumericUpDown nupPersonas;
    }
}