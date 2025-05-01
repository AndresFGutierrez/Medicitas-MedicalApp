namespace PryPresentacion
{
    partial class FrmHistorialMedico
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtIDmedico1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIDpaciente1 = new System.Windows.Forms.TextBox();
            this.txtTratamiento1 = new System.Windows.Forms.TextBox();
            this.txtDiagnostico1 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.dgvHMedico = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.Silver;
            this.txtIdentificacion.Location = new System.Drawing.Point(47, 110);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(225, 27);
            this.txtIdentificacion.TabIndex = 29;
            this.txtIdentificacion.Text = "Ingrese ID del PACIENTE";
            this.txtIdentificacion.Enter += new System.EventHandler(this.txtIdentificacion_Enter);
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            this.txtIdentificacion.Leave += new System.EventHandler(this.txtIdentificacion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "INGRESE DATOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 298);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(324, 106);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = false;
            this.btnBuscar.Size = new System.Drawing.Size(65, 36);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpFecha1);
            this.panel1.Controls.Add(this.txtIDmedico1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtIDpaciente1);
            this.panel1.Controls.Add(this.txtTratamiento1);
            this.panel1.Controls.Add(this.txtDiagnostico1);
            this.panel1.Controls.Add(this.txtID1);
            this.panel1.Controls.Add(this.dgvHMedico);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 420);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir Modo Administrador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Location = new System.Drawing.Point(391, 31);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(225, 26);
            this.dtpFecha1.TabIndex = 26;
            // 
            // txtIDmedico1
            // 
            this.txtIDmedico1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDmedico1.ForeColor = System.Drawing.Color.Silver;
            this.txtIDmedico1.Location = new System.Drawing.Point(391, 98);
            this.txtIDmedico1.Name = "txtIDmedico1";
            this.txtIDmedico1.Size = new System.Drawing.Size(225, 27);
            this.txtIDmedico1.TabIndex = 25;
            this.txtIDmedico1.Text = "ID Medico";
            this.txtIDmedico1.Enter += new System.EventHandler(this.txtIDmedico1_Enter);
            this.txtIDmedico1.Leave += new System.EventHandler(this.txtIDmedico1_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(410, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 29);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(323, 142);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 29);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(242, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 29);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIDpaciente1
            // 
            this.txtIDpaciente1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDpaciente1.ForeColor = System.Drawing.Color.Silver;
            this.txtIDpaciente1.Location = new System.Drawing.Point(391, 65);
            this.txtIDpaciente1.Name = "txtIDpaciente1";
            this.txtIDpaciente1.Size = new System.Drawing.Size(225, 27);
            this.txtIDpaciente1.TabIndex = 21;
            this.txtIDpaciente1.Text = "ID Paciente";
            this.txtIDpaciente1.Enter += new System.EventHandler(this.txtIDpaciente1_Enter);
            this.txtIDpaciente1.Leave += new System.EventHandler(this.txtIDpaciente1_Leave);
            // 
            // txtTratamiento1
            // 
            this.txtTratamiento1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento1.ForeColor = System.Drawing.Color.Silver;
            this.txtTratamiento1.Location = new System.Drawing.Point(136, 98);
            this.txtTratamiento1.Name = "txtTratamiento1";
            this.txtTratamiento1.Size = new System.Drawing.Size(225, 27);
            this.txtTratamiento1.TabIndex = 19;
            this.txtTratamiento1.Text = "Tratamiento";
            this.txtTratamiento1.Enter += new System.EventHandler(this.txtTratamiento1_Enter);
            this.txtTratamiento1.Leave += new System.EventHandler(this.txtTratamiento1_Leave);
            // 
            // txtDiagnostico1
            // 
            this.txtDiagnostico1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico1.ForeColor = System.Drawing.Color.Silver;
            this.txtDiagnostico1.Location = new System.Drawing.Point(136, 65);
            this.txtDiagnostico1.Name = "txtDiagnostico1";
            this.txtDiagnostico1.Size = new System.Drawing.Size(225, 27);
            this.txtDiagnostico1.TabIndex = 18;
            this.txtDiagnostico1.Text = "Diagnostico";
            this.txtDiagnostico1.Enter += new System.EventHandler(this.txtDiagnostico1_Enter);
            this.txtDiagnostico1.Leave += new System.EventHandler(this.txtDiagnostico1_Leave);
            // 
            // txtID1
            // 
            this.txtID1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID1.ForeColor = System.Drawing.Color.Silver;
            this.txtID1.Location = new System.Drawing.Point(136, 33);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(225, 27);
            this.txtID1.TabIndex = 17;
            this.txtID1.Text = "ID Historial";
            this.txtID1.Enter += new System.EventHandler(this.txtID1_Enter);
            this.txtID1.Leave += new System.EventHandler(this.txtID1_Leave);
            // 
            // dgvHMedico
            // 
            this.dgvHMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvHMedico.Location = new System.Drawing.Point(16, 217);
            this.dgvHMedico.Name = "dgvHMedico";
            this.dgvHMedico.Size = new System.Drawing.Size(741, 179);
            this.dgvHMedico.TabIndex = 16;
            this.dgvHMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedico_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::PryPresentacion.Properties.Resources.Editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(538, 106);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmHistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmHistorialMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Medico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHMedico;
        private System.Windows.Forms.TextBox txtIDpaciente1;
        private System.Windows.Forms.TextBox txtTratamiento1;
        private System.Windows.Forms.TextBox txtDiagnostico1;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIDmedico1;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}