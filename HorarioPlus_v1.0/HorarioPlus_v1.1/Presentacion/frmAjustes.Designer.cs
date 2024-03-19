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
            this.cbxDiaLaborales = new System.Windows.Forms.ComboBox();
            this.btnCerrarSistema = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEmpresa = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.pnlAjustesSistema = new System.Windows.Forms.Panel();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaTarde = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numPagoHora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCancelarDatos = new FontAwesome.Sharp.IconButton();
            this.btnGuardarDatos = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEmpresa.SuspendLayout();
            this.pnlAjustesSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagoHora)).BeginInit();
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
            // cbxDiaLaborales
            // 
            this.cbxDiaLaborales.FormattingEnabled = true;
            this.cbxDiaLaborales.Location = new System.Drawing.Point(13, 54);
            this.cbxDiaLaborales.Name = "cbxDiaLaborales";
            this.cbxDiaLaborales.Size = new System.Drawing.Size(190, 21);
            this.cbxDiaLaborales.TabIndex = 16;
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
            this.btnCerrarSistema.Location = new System.Drawing.Point(622, 17);
            this.btnCerrarSistema.Name = "btnCerrarSistema";
            this.btnCerrarSistema.Size = new System.Drawing.Size(99, 29);
            this.btnCerrarSistema.TabIndex = 19;
            this.btnCerrarSistema.Text = "Cerrar Sistema";
            this.btnCerrarSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSistema.UseVisualStyleBackColor = false;
            this.btnCerrarSistema.Click += new System.EventHandler(this.btnCerrarSistema_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 1;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(545, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 34);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatosEmpresa
            // 
            this.pnlDatosEmpresa.Controls.Add(this.txtCorreo);
            this.pnlDatosEmpresa.Controls.Add(this.label8);
            this.pnlDatosEmpresa.Controls.Add(this.txtTelefono);
            this.pnlDatosEmpresa.Controls.Add(this.label7);
            this.pnlDatosEmpresa.Controls.Add(this.txtDireccionEmpresa);
            this.pnlDatosEmpresa.Controls.Add(this.label5);
            this.pnlDatosEmpresa.Controls.Add(this.txtNombreEmpresa);
            this.pnlDatosEmpresa.Controls.Add(this.label4);
            this.pnlDatosEmpresa.Controls.Add(this.label3);
            this.pnlDatosEmpresa.Location = new System.Drawing.Point(35, 114);
            this.pnlDatosEmpresa.Name = "pnlDatosEmpresa";
            this.pnlDatosEmpresa.Size = new System.Drawing.Size(224, 240);
            this.pnlDatosEmpresa.TabIndex = 26;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Silver;
            this.txtCorreo.Location = new System.Drawing.Point(7, 191);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 20);
            this.txtCorreo.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(7, 147);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 20);
            this.txtTelefono.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telefono:";
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.BackColor = System.Drawing.Color.Silver;
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(7, 99);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(190, 20);
            this.txtDireccionEmpresa.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direccion:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BackColor = System.Drawing.Color.Silver;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(7, 54);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(190, 20);
            this.txtNombreEmpresa.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre de la Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datos Empresa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(636, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 34);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlAjustesSistema
            // 
            this.pnlAjustesSistema.Controls.Add(this.dtpHoraEntrada);
            this.pnlAjustesSistema.Controls.Add(this.dtpEntradaTarde);
            this.pnlAjustesSistema.Controls.Add(this.dtpHoraSalida);
            this.pnlAjustesSistema.Controls.Add(this.label14);
            this.pnlAjustesSistema.Controls.Add(this.label6);
            this.pnlAjustesSistema.Controls.Add(this.label2);
            this.pnlAjustesSistema.Controls.Add(this.label11);
            this.pnlAjustesSistema.Controls.Add(this.numPagoHora);
            this.pnlAjustesSistema.Controls.Add(this.label1);
            this.pnlAjustesSistema.Controls.Add(this.label13);
            this.pnlAjustesSistema.Controls.Add(this.cbxDiaLaborales);
            this.pnlAjustesSistema.Location = new System.Drawing.Point(291, 114);
            this.pnlAjustesSistema.Name = "pnlAjustesSistema";
            this.pnlAjustesSistema.Size = new System.Drawing.Size(430, 240);
            this.pnlAjustesSistema.TabIndex = 37;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "HH:mm";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(13, 148);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(190, 20);
            this.dtpHoraEntrada.TabIndex = 53;
            // 
            // dtpEntradaTarde
            // 
            this.dtpEntradaTarde.CustomFormat = "HH:mm";
            this.dtpEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntradaTarde.Location = new System.Drawing.Point(13, 193);
            this.dtpEntradaTarde.Name = "dtpEntradaTarde";
            this.dtpEntradaTarde.ShowUpDown = true;
            this.dtpEntradaTarde.Size = new System.Drawing.Size(190, 20);
            this.dtpEntradaTarde.TabIndex = 52;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(224, 53);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(190, 20);
            this.dtpHoraSalida.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(221, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Hora Salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Entrada Tarde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hora Entrada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Dias Laborales:";
            // 
            // numPagoHora
            // 
            this.numPagoHora.BackColor = System.Drawing.Color.Silver;
            this.numPagoHora.Location = new System.Drawing.Point(13, 99);
            this.numPagoHora.Name = "numPagoHora";
            this.numPagoHora.Size = new System.Drawing.Size(190, 20);
            this.numPagoHora.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pago por Hora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ajustes Sistema";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelContenedor.Controls.Add(this.btnCancelarDatos);
            this.panelContenedor.Controls.Add(this.btnGuardarDatos);
            this.panelContenedor.Controls.Add(this.pnlAjustesSistema);
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Controls.Add(this.pnlDatosEmpresa);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.btnCerrarSistema);
            this.panelContenedor.Controls.Add(this.lblTitulo);
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
            this.btnCancelarDatos.Location = new System.Drawing.Point(174, 369);
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
            this.btnGuardarDatos.Location = new System.Drawing.Point(83, 369);
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
            this.Text = "frmAjustes";
            this.pnlDatosEmpresa.ResumeLayout(false);
            this.pnlDatosEmpresa.PerformLayout();
            this.pnlAjustesSistema.ResumeLayout(false);
            this.pnlAjustesSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagoHora)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxDiaLaborales;
        private FontAwesome.Sharp.IconButton btnCerrarSistema;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel pnlDatosEmpresa;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Panel pnlAjustesSistema;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPagoHora;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntradaTarde;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private FontAwesome.Sharp.IconButton btnCancelarDatos;
        private FontAwesome.Sharp.IconButton btnGuardarDatos;
    }
}