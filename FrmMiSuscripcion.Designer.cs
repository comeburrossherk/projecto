namespace suscripciones_proyecto_intento1
{
    partial class FrmMiSuscripcion
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
            lblPlan = new Label();
            dgvPagos = new DataGridView();
            label2 = new Label();
            cmbMetodo = new ComboBox();
            btnRenovar = new Button();
            btnCambiarPlan = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // lblPlan
            // 
            lblPlan.Location = new Point(12, 18);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(158, 204);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "";
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(654, 128);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 51;
            dgvPagos.Size = new Size(556, 405);
            dgvPagos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 234);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Método de pago";
            // 
            // cmbMetodo
            // 
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Location = new Point(1, 257);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(151, 28);
            cmbMetodo.TabIndex = 3;
            // 
            // btnRenovar
            // 
            btnRenovar.Location = new Point(341, 256);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(195, 43);
            btnRenovar.TabIndex = 4;
            btnRenovar.Text = "Renovar por 1 mes";
            btnRenovar.UseVisualStyleBackColor = true;
            btnRenovar.Click += btnRenovar_Click;
            // 
            // btnCambiarPlan
            // 
            btnCambiarPlan.Location = new Point(341, 332);
            btnCambiarPlan.Name = "btnCambiarPlan";
            btnCambiarPlan.Size = new Size(195, 40);
            btnCambiarPlan.TabIndex = 5;
            btnCambiarPlan.Text = "Cambiar de plan";
            btnCambiarPlan.UseVisualStyleBackColor = true;
            btnCambiarPlan.Click += btnCambiarPlan_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(341, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar mi suscripción";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmMiSuscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 573);
            Controls.Add(btnCancelar);
            Controls.Add(btnCambiarPlan);
            Controls.Add(btnRenovar);
            Controls.Add(cmbMetodo);
            Controls.Add(label2);
            Controls.Add(dgvPagos);
            Controls.Add(lblPlan);
            Name = "FrmMiSuscripcion";
            Text = "Mi suscripción";
            Load += FrmMiSuscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlan;
        private DataGridView dgvPagos;
        private Label label2;
        private ComboBox cmbMetodo;
        private Button btnRenovar;
        private Button btnCambiarPlan;
        private Button btnCancelar;
    }
}