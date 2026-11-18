namespace suscripciones_proyecto_intento1
{
    partial class FrmAdmin
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
            dgvContenidos = new DataGridView();
            txtTitulo = new TextBox();
            cmbTipo = new ComboBox();
            txtGenero = new TextBox();
            nudAño = new NumericUpDown();
            nudDuracion = new NumericUpDown();
            cmbClasificacion = new ComboBox();
            nudNivel = new NumericUpDown();
            txtSinopsis = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnEstadisticas = new Button();
            btnCerrarSesion = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContenidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).BeginInit();
            SuspendLayout();
            // 
            // dgvContenidos
            // 
            dgvContenidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContenidos.Location = new Point(681, 98);
            dgvContenidos.Name = "dgvContenidos";
            dgvContenidos.RowHeadersWidth = 51;
            dgvContenidos.Size = new Size(589, 450);
            dgvContenidos.TabIndex = 0;
            dgvContenidos.CellClick += dgvContenidos_CellContentClick;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(41, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(333, 27);
            txtTitulo.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(42, 122);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 2;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(42, 182);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(125, 27);
            txtGenero.TabIndex = 3;
            // 
            // nudAño
            // 
            nudAño.Location = new Point(43, 240);
            nudAño.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            nudAño.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudAño.Name = "nudAño";
            nudAño.Size = new Size(150, 27);
            nudAño.TabIndex = 4;
            nudAño.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(42, 292);
            nudDuracion.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(150, 27);
            nudDuracion.TabIndex = 5;
            nudDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Location = new Point(41, 344);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(151, 28);
            cmbClasificacion.TabIndex = 6;
            // 
            // nudNivel
            // 
            nudNivel.Location = new Point(42, 402);
            nudNivel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudNivel.Name = "nudNivel";
            nudNivel.Size = new Size(150, 27);
            nudNivel.TabIndex = 7;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(43, 464);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(125, 121);
            txtSinopsis.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(509, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(509, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(509, 277);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(509, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(509, 453);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(130, 29);
            btnEstadisticas.TabIndex = 13;
            btnEstadisticas.Text = "Ver estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(1140, 589);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(158, 29);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 15;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 99);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 16;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 159);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 17;
            label3.Text = "Género";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 217);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 18;
            label4.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 270);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 19;
            label5.Text = "Duración (min)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 322);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 20;
            label6.Text = "Clasificación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 379);
            label7.Name = "label7";
            label7.Size = new Size(168, 20);
            label7.TabIndex = 21;
            label7.Text = "Nivel necesario para ver";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 441);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 22;
            label8.Text = "Sinopsis";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 639);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtSinopsis);
            Controls.Add(nudNivel);
            Controls.Add(cmbClasificacion);
            Controls.Add(nudDuracion);
            Controls.Add(nudAño);
            Controls.Add(txtGenero);
            Controls.Add(cmbTipo);
            Controls.Add(txtTitulo);
            Controls.Add(dgvContenidos);
            Name = "FrmAdmin";
            Text = "Panel de administración";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContenidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContenidos;
        private TextBox txtTitulo;
        private ComboBox cmbTipo;
        private TextBox txtGenero;
        private NumericUpDown nudAño;
        private NumericUpDown nudDuracion;
        private ComboBox cmbClasificacion;
        private NumericUpDown nudNivel;
        private TextBox txtSinopsis;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnEstadisticas;
        private Button btnCerrarSesion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}