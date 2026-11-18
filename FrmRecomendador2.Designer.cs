namespace suscripciones_proyecto_intento1
{
    partial class FrmRecomendador2
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
            lblRecomendacion = new Label();
            chk4K = new CheckBox();
            dgvPlanes = new DataGridView();
            label3 = new Label();
            cmbMetodo = new ComboBox();
            btnContratar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(52, 71);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 0;
            label1.Text = "Elige tu plan";
            // 
            // lblRecomendacion
            // 
            lblRecomendacion.Location = new Point(27, 103);
            lblRecomendacion.Name = "lblRecomendacion";
            lblRecomendacion.Size = new Size(490, 139);
            lblRecomendacion.TabIndex = 1;
            // 
            // chk4K
            // 
            chk4K.AutoSize = true;
            chk4K.Location = new Point(52, 279);
            chk4K.Name = "chk4K";
            chk4K.Size = new Size(141, 24);
            chk4K.TabIndex = 2;
            chk4K.Text = "Quiero ver en 4K";
            chk4K.UseVisualStyleBackColor = true;
            chk4K.CheckedChanged += chk4K_CheckedChanged;
            // 
            // dgvPlanes
            // 
            dgvPlanes.AllowUserToAddRows = false;
            dgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(464, 233);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanes.Size = new Size(823, 268);
            dgvPlanes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 371);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 4;
            label3.Text = "Método de pago";
            // 
            // cmbMetodo
            // 
            cmbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Location = new Point(42, 394);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(151, 28);
            cmbMetodo.TabIndex = 5;
            // 
            // btnContratar
            // 
            btnContratar.Location = new Point(42, 511);
            btnContratar.Name = "btnContratar";
            btnContratar.Size = new Size(153, 53);
            btnContratar.TabIndex = 6;
            btnContratar.Text = "Contratar";
            btnContratar.UseVisualStyleBackColor = true;
            btnContratar.Click += btnContratar_Click;
            // 
            // FrmRecomendador2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 626);
            Controls.Add(btnContratar);
            Controls.Add(cmbMetodo);
            Controls.Add(label3);
            Controls.Add(dgvPlanes);
            Controls.Add(chk4K);
            Controls.Add(lblRecomendacion);
            Controls.Add(label1);
            Name = "FrmRecomendador2";
            Text = "Elige tu plan";
            Load += FrmRecomendador2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRecomendacion;
        private CheckBox chk4K;
        private DataGridView dgvPlanes;
        private Label label3;
        private ComboBox cmbMetodo;
        private Button btnContratar;
    }
}