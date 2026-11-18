namespace suscripciones_proyecto_intento1
{
    partial class FrmPrincipal
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
            label1 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            btnOlvide = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 49);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(157, 167);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(166, 27);
            txtCorreo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 143);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 248);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(157, 272);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(166, 27);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(157, 336);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(105, 31);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnOlvide
            // 
            btnOlvide.Location = new Point(680, 513);
            btnOlvide.Margin = new Padding(3, 4, 3, 4);
            btnOlvide.Name = "btnOlvide";
            btnOlvide.Size = new Size(150, 31);
            btnOlvide.TabIndex = 6;
            btnOlvide.Text = "Olvidé mi contraseña";
            btnOlvide.UseVisualStyleBackColor = true;
            btnOlvide.Click += btnOlvide_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnOlvide);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private Button btnOlvide;
    }
}