namespace suscripciones_proyecto_intento1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            iniciarsesion = new Button();
            crearcuenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a NovaStream";
            // 
            // iniciarsesion
            // 
            iniciarsesion.Location = new Point(449, 316);
            iniciarsesion.Margin = new Padding(3, 4, 3, 4);
            iniciarsesion.Name = "iniciarsesion";
            iniciarsesion.Size = new Size(203, 49);
            iniciarsesion.TabIndex = 1;
            iniciarsesion.Text = "Iniciar sesión";
            iniciarsesion.UseVisualStyleBackColor = true;
            iniciarsesion.Click += iniciarsesion_Click;
            // 
            // crearcuenta
            // 
            crearcuenta.Location = new Point(449, 431);
            crearcuenta.Margin = new Padding(3, 4, 3, 4);
            crearcuenta.Name = "crearcuenta";
            crearcuenta.Size = new Size(203, 51);
            crearcuenta.TabIndex = 2;
            crearcuenta.Text = "Crear una cuenta";
            crearcuenta.UseVisualStyleBackColor = true;
            crearcuenta.Click += crearcuenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 1013);
            Controls.Add(crearcuenta);
            Controls.Add(iniciarsesion);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "NovaStream";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button iniciarsesion;
        private Button crearcuenta;
    }
}
