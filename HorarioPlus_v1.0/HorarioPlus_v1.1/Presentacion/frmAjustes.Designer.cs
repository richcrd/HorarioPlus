namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmAjustes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSistema = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEmpresa = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCancelarDatos = new FontAwesome.Sharp.IconButton();
            this.btnGuardarDatos = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEmpresa.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(250, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONFIGURACION SISTEMA";
            // 
            // btnCerrarSistema
            // 
            this.btnCerrarSistema.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSistema.FlatAppearance.BorderSize = 0;
            this.btnCerrarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSistema.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSistema.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnCerrarSistema.IconColor = System.Drawing.Color.White;
            this.btnCerrarSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSistema.IconSize = 1;
            this.btnCerrarSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSistema.Location = new System.Drawing.Point(649, 17);
            this.btnCerrarSistema.Name = "btnCerrarSistema";
            this.btnCerrarSistema.Size = new System.Drawing.Size(99, 29);
            this.btnCerrarSistema.TabIndex = 19;
            this.btnCerrarSistema.Text = "Cerrar Sistema";
            this.btnCerrarSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSistema.UseVisualStyleBackColor = false;
            this.btnCerrarSistema.Click += new System.EventHandler(this.btnCerrarSistema_Click);
            // 
            // pnlDatosEmpresa
            // 
            this.pnlDatosEmpresa.BackColor = System.Drawing.Color.SlateGray;
            this.pnlDatosEmpresa.Controls.Add(this.txtCorreo);
            this.pnlDatosEmpresa.Controls.Add(this.label8);
            this.pnlDatosEmpresa.Controls.Add(this.txtTelefono);
            this.pnlDatosEmpresa.Controls.Add(this.label7);
            this.pnlDatosEmpresa.Controls.Add(this.txtDireccion);
            this.pnlDatosEmpresa.Controls.Add(this.label5);
            this.pnlDatosEmpresa.Controls.Add(this.txtNombre);
            this.pnlDatosEmpresa.Controls.Add(this.label4);
            this.pnlDatosEmpresa.Location = new System.Drawing.Point(167, 107);
            this.pnlDatosEmpresa.Name = "pnlDatosEmpresa";
            this.pnlDatosEmpresa.Size = new System.Drawing.Size(463, 240);
            this.pnlDatosEmpresa.TabIndex = 26;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Silver;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(233, 142);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 30);
            this.txtCorreo.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(230, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(10, 142);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 30);
            this.txtTelefono.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(233, 57);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(190, 30);
            this.txtDireccion.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(10, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 30);
            this.txtNombre.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre de la Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datos Empresa";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelContenedor.Controls.Add(this.btnCancelarDatos);
            this.panelContenedor.Controls.Add(this.pnlDatosEmpresa);
            this.panelContenedor.Controls.Add(this.btnGuardarDatos);
            this.panelContenedor.Controls.Add(this.btnCerrarSistema);
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(770, 450);
            this.panelContenedor.TabIndex = 32;
            // 
            // btnCancelarDatos
            // 
            this.btnCancelarDatos.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDatos.FlatAppearance.BorderSize = 0;
            this.btnCancelarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDatos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarDatos.IconColor = System.Drawing.Color.White;
            this.btnCancelarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarDatos.IconSize = 1;
            this.btnCancelarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDatos.Location = new System.Drawing.Point(545, 353);
            this.btnCancelarDatos.Name = "btnCancelarDatos";
            this.btnCancelarDatos.Size = new System.Drawing.Size(85, 34);
            this.btnCancelarDatos.TabIndex = 39;
            this.btnCancelarDatos.Text = "Cancelar";
            this.btnCancelarDatos.UseVisualStyleBackColor = false;
            this.btnCancelarDatos.Click += new System.EventHandler(this.btnCancelarDatos_Click);
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.Color.Green;
            this.btnGuardarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDatos.FlatAppearance.BorderSize = 0;
            this.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDatos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDatos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarDatos.IconColor = System.Drawing.Color.White;
            this.btnGuardarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarDatos.IconSize = 1;
            this.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDatos.Location = new System.Drawing.Point(445, 353);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(85, 34);
            this.btnGuardarDatos.TabIndex = 38;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.panelContenedor);
            this.MinimumSize = new System.Drawing.Size(788, 489);
            this.Name = "frmAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjustes";
            this.pnlDatosEmpresa.ResumeLayout(false);
            this.pnlDatosEmpresa.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnCerrarSistema;
        private System.Windows.Forms.Panel pnlDatosEmpresa;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnCancelarDatos;
        private FontAwesome.Sharp.IconButton btnGuardarDatos;
    }
}