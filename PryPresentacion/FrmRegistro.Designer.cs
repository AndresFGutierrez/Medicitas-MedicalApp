namespace PryPresentacion
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
            this.LbTituloRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.TxtRegistroEmail = new System.Windows.Forms.TextBox();
            this.TxtRegistroContraseña = new System.Windows.Forms.TextBox();
            this.TxtRegistroConfirmar = new System.Windows.Forms.TextBox();
            this.CbRegistroCargo = new System.Windows.Forms.ComboBox();
            this.BtnRegistrarse = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // LbTituloRegistro
            // 
            this.LbTituloRegistro.AutoSize = true;
            this.LbTituloRegistro.Depth = 0;
            this.LbTituloRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LbTituloRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbTituloRegistro.Location = new System.Drawing.Point(274, 125);
            this.LbTituloRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbTituloRegistro.Name = "LbTituloRegistro";
            this.LbTituloRegistro.Size = new System.Drawing.Size(216, 19);
            this.LbTituloRegistro.TabIndex = 0;
            this.LbTituloRegistro.Text = "REGISTRATE NUEVO USUARIO";
            // 
            // TxtRegistroEmail
            // 
            this.TxtRegistroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistroEmail.ForeColor = System.Drawing.Color.Silver;
            this.TxtRegistroEmail.Location = new System.Drawing.Point(278, 170);
            this.TxtRegistroEmail.Name = "TxtRegistroEmail";
            this.TxtRegistroEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRegistroEmail.Size = new System.Drawing.Size(231, 29);
            this.TxtRegistroEmail.TabIndex = 1;
            this.TxtRegistroEmail.Text = "Email";
            this.TxtRegistroEmail.Enter += new System.EventHandler(this.TxtRegistroEmail_Enter);
            this.TxtRegistroEmail.Leave += new System.EventHandler(this.TxtRegistroEmail_Leave);
            // 
            // TxtRegistroContraseña
            // 
            this.TxtRegistroContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistroContraseña.ForeColor = System.Drawing.Color.Silver;
            this.TxtRegistroContraseña.Location = new System.Drawing.Point(278, 205);
            this.TxtRegistroContraseña.Name = "TxtRegistroContraseña";
            this.TxtRegistroContraseña.Size = new System.Drawing.Size(231, 29);
            this.TxtRegistroContraseña.TabIndex = 2;
            this.TxtRegistroContraseña.Text = "Contraseña";
            this.TxtRegistroContraseña.Enter += new System.EventHandler(this.TxtRegistroContraseña_Enter);
            this.TxtRegistroContraseña.Leave += new System.EventHandler(this.TxtRegistroContraseña_Leave);
            // 
            // TxtRegistroConfirmar
            // 
            this.TxtRegistroConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistroConfirmar.ForeColor = System.Drawing.Color.Silver;
            this.TxtRegistroConfirmar.Location = new System.Drawing.Point(278, 240);
            this.TxtRegistroConfirmar.Name = "TxtRegistroConfirmar";
            this.TxtRegistroConfirmar.Size = new System.Drawing.Size(231, 29);
            this.TxtRegistroConfirmar.TabIndex = 3;
            this.TxtRegistroConfirmar.Text = "Confirme Contraseña";
            this.TxtRegistroConfirmar.Enter += new System.EventHandler(this.TxtRegistroConfirmar_Enter);
            this.TxtRegistroConfirmar.Leave += new System.EventHandler(this.TxtRegistroConfirmar_Leave);
            // 
            // CbRegistroCargo
            // 
            this.CbRegistroCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRegistroCargo.ForeColor = System.Drawing.Color.Silver;
            this.CbRegistroCargo.FormattingEnabled = true;
            this.CbRegistroCargo.Items.AddRange(new object[] {
            "Medico",
            "Paciente"});
            this.CbRegistroCargo.Location = new System.Drawing.Point(278, 275);
            this.CbRegistroCargo.Name = "CbRegistroCargo";
            this.CbRegistroCargo.Size = new System.Drawing.Size(231, 32);
            this.CbRegistroCargo.TabIndex = 4;
            this.CbRegistroCargo.Text = "Cargo";
            this.CbRegistroCargo.Enter += new System.EventHandler(this.CbRegistroCargo_Enter);
            this.CbRegistroCargo.Leave += new System.EventHandler(this.CbRegistroCargo_Leave);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.AutoSize = true;
            this.BtnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRegistrarse.Depth = 0;
            this.BtnRegistrarse.Location = new System.Drawing.Point(343, 338);
            this.BtnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Primary = false;
            this.BtnRegistrarse.Size = new System.Drawing.Size(100, 36);
            this.BtnRegistrarse.TabIndex = 5;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = true;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.CbRegistroCargo);
            this.Controls.Add(this.TxtRegistroConfirmar);
            this.Controls.Add(this.TxtRegistroContraseña);
            this.Controls.Add(this.TxtRegistroEmail);
            this.Controls.Add(this.LbTituloRegistro);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATE EN MEDICITAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LbTituloRegistro;
        private System.Windows.Forms.TextBox TxtRegistroEmail;
        private System.Windows.Forms.TextBox TxtRegistroContraseña;
        private System.Windows.Forms.TextBox TxtRegistroConfirmar;
        private System.Windows.Forms.ComboBox CbRegistroCargo;
        private MaterialSkin.Controls.MaterialFlatButton BtnRegistrarse;
    }
}