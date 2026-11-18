namespace suscripciones_proyecto_intento1
{
    partial class FrmEstadisticas
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
            lblClientes = new Label();
            lblActivas = new Label();
            lblIngresos = new Label();
            label4 = new Label();
            dgvPorPlan = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            dgvPorTipo = new DataGridView();
            dgvMasVistos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPorPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPorTipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMasVistos).BeginInit();
            SuspendLayout();
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(35, 71);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(0, 20);
            lblClientes.TabIndex = 0;
            // 
            // lblActivas
            // 
            lblActivas.AutoSize = true;
            lblActivas.Location = new Point(53, 147);
            lblActivas.Name = "lblActivas";
            lblActivas.Size = new Size(0, 20);
            lblActivas.TabIndex = 1;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(53, 228);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(0, 20);
            lblIngresos.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 269);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 3;
            label4.Text = "Contenido por tipo";
            // 
            // dgvPorPlan
            // 
            dgvPorPlan.AllowUserToAddRows = false;
            dgvPorPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPorPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorPlan.Location = new Point(35, 326);
            dgvPorPlan.Name = "dgvPorPlan";
            dgvPorPlan.ReadOnly = true;
            dgvPorPlan.RowHeadersVisible = false;
            dgvPorPlan.RowHeadersWidth = 51;
            dgvPorPlan.Size = new Size(300, 188);
            dgvPorPlan.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(963, 269);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 5;
            label5.Text = "Lo más visto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 269);
            label6.Name = "label6";
            label6.Size = new Size(217, 20);
            label6.TabIndex = 6;
            label6.Text = "Suscripciones vigentes por plan";
            // 
            // dgvPorTipo
            // 
            dgvPorTipo.AllowUserToAddRows = false;
            dgvPorTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPorTipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorTipo.Location = new Point(470, 326);
            dgvPorTipo.Name = "dgvPorTipo";
            dgvPorTipo.ReadOnly = true;
            dgvPorTipo.RowHeadersVisible = false;
            dgvPorTipo.RowHeadersWidth = 51;
            dgvPorTipo.Size = new Size(300, 188);
            dgvPorTipo.TabIndex = 7;
            // 
            // dgvMasVistos
            // 
            dgvMasVistos.AllowUserToAddRows = false;
            dgvMasVistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMasVistos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasVistos.Location = new Point(951, 326);
            dgvMasVistos.Name = "dgvMasVistos";
            dgvMasVistos.ReadOnly = true;
            dgvMasVistos.RowHeadersVisible = false;
            dgvMasVistos.RowHeadersWidth = 51;
            dgvMasVistos.Size = new Size(300, 188);
            dgvMasVistos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 127);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 10;
            label2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 187);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 11;
            label3.Text = "";
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 629);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMasVistos);
            Controls.Add(dgvPorTipo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvPorPlan);
            Controls.Add(label4);
            Controls.Add(lblIngresos);
            Controls.Add(lblActivas);
            Controls.Add(lblClientes);
            Name = "FrmEstadisticas";
            Text = "Estadísticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPorPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPorTipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMasVistos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClientes;
        private Label lblActivas;
        private Label lblIngresos;
        private Label label4;
        private DataGridView dgvPorPlan;
        private Label label5;
        private Label label6;
        private DataGridView dgvPorTipo;
        private DataGridView dgvMasVistos;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}