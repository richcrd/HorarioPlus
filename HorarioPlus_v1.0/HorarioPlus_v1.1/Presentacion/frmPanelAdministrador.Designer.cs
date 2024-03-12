namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmPanelAdministrador
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesionAdmin = new FontAwesome.Sharp.IconButton();
            this.btnAjustes = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.MenuStrip();
            this.menuAsistencias = new FontAwesome.Sharp.IconMenuItem();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuNuevoRegistro = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPagos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPagos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDeducciones = new FontAwesome.Sharp.IconMenuItem();
            this.menuNominas = new FontAwesome.Sharp.IconMenuItem();
            this.menuCarnet = new FontAwesome.Sharp.IconMenuItem();
            this.menuActividad = new FontAwesome.Sharp.IconMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.lblUsuario);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnCerrarSesionAdmin);
            this.pnlTop.Controls.Add(this.btnAjustes);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(770, 44);
            this.pnlTop.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(115, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador:";
            // 
            // btnCerrarSesionAdmin
            // 
            this.btnCerrarSesionAdmin.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesionAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionAdmin.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesionAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesionAdmin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesionAdmin.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesionAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesionAdmin.IconSize = 15;
            this.btnCerrarSesionAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesionAdmin.Location = new System.Drawing.Point(679, 9);
            this.btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin";
            this.btnCerrarSesionAdmin.Size = new System.Drawing.Size(70, 23);
            this.btnCerrarSesionAdmin.TabIndex = 8;
            this.btnCerrarSesionAdmin.Text = "Cerrar Sesion";
            this.btnCerrarSesionAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesionAdmin.UseVisualStyleBackColor = false;
            this.btnCerrarSesionAdmin.Click += new System.EventHandler(this.btnCerrarSesionAdmin_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Gray;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnAjustes.IconColor = System.Drawing.Color.White;
            this.btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjustes.IconSize = 15;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Location = new System.Drawing.Point(603, 9);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(70, 23);
            this.btnAjustes.TabIndex = 9;
            this.btnAjustes.Text = "Ajustes Sistema";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pnlMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAsistencias,
            this.menuEmpleados,
            this.menuPagos,
            this.menuNominas,
            this.menuCarnet,
            this.menuActividad});
            this.pnlMenu.Location = new System.Drawing.Point(0, 44);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.pnlMenu.Size = new System.Drawing.Size(770, 56);
            this.pnlMenu.TabIndex = 4;
            this.pnlMenu.Text = "menuStrip1";
            // 
            // menuAsistencias
            // 
            this.menuAsistencias.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.menuAsistencias.IconColor = System.Drawing.Color.Black;
            this.menuAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAsistencias.IconSize = 35;
            this.menuAsistencias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAsistencias.Name = "menuAsistencias";
            this.menuAsistencias.Size = new System.Drawing.Size(77, 54);
            this.menuAsistencias.Text = "Asistencias";
            this.menuAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAsistencias.Click += new System.EventHandler(this.menuAsistencias_Click);
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuNuevoRegistro,
            this.subMenuHorarios});
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.IconSize = 35;
            this.menuEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(77, 54);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuNuevoRegistro
            // 
            this.subMenuNuevoRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuNuevoRegistro.IconColor = System.Drawing.Color.Black;
            this.subMenuNuevoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuNuevoRegistro.Name = "subMenuNuevoRegistro";
            this.subMenuNuevoRegistro.Size = new System.Drawing.Size(155, 22);
            this.subMenuNuevoRegistro.Text = "Nuevo Registro";
            this.subMenuNuevoRegistro.Click += new System.EventHandler(this.subMenuNuevoRegistro_Click_1);
            // 
            // subMenuHorarios
            // 
            this.subMenuHorarios.Name = "subMenuHorarios";
            this.subMenuHorarios.Size = new System.Drawing.Size(188, 30);
            this.subMenuHorarios.Text = "Horarios";
            this.subMenuHorarios.Click += new System.EventHandler(this.subMenuHorarios_Click);
            // 
            // menuPagos
            // 
            this.menuPagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPagos,
            this.subMenuDeducciones});
            this.menuPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.menuPagos.IconColor = System.Drawing.Color.Black;
            this.menuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPagos.IconSize = 35;
            this.menuPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPagos.Name = "menuPagos";
            this.menuPagos.Size = new System.Drawing.Size(51, 54);
            this.menuPagos.Text = "Pagos";
            this.menuPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuPagos
            // 
            this.subMenuPagos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPagos.IconColor = System.Drawing.Color.Black;
            this.subMenuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPagos.Name = "subMenuPagos";
            this.subMenuPagos.Size = new System.Drawing.Size(188, 30);
            this.subMenuPagos.Text = "Pagos";
            this.subMenuPagos.Click += new System.EventHandler(this.subMenuPagos_Click);
            // 
            // subMenuDeducciones
            // 
            this.subMenuDeducciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDeducciones.IconColor = System.Drawing.Color.Black;
            this.subMenuDeducciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDeducciones.Name = "subMenuDeducciones";
            this.subMenuDeducciones.Size = new System.Drawing.Size(188, 30);
            this.subMenuDeducciones.Text = "Deducciones";
            this.subMenuDeducciones.Click += new System.EventHandler(this.subMenuDeducciones_Click);
            // 
            // menuNominas
            // 
            this.menuNominas.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.menuNominas.IconColor = System.Drawing.Color.Black;
            this.menuNominas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuNominas.IconSize = 35;
            this.menuNominas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuNominas.Name = "menuNominas";
            this.menuNominas.Size = new System.Drawing.Size(67, 54);
            this.menuNominas.Text = "Nominas";
            this.menuNominas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuNominas.Click += new System.EventHandler(this.menuNominas_Click);
            // 
            // menuCarnet
            // 
            this.menuCarnet.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.menuCarnet.IconColor = System.Drawing.Color.Black;
            this.menuCarnet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCarnet.IconSize = 35;
            this.menuCarnet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCarnet.Name = "menuCarnet";
            this.menuCarnet.Size = new System.Drawing.Size(54, 54);
            this.menuCarnet.Text = "Carnet";
            this.menuCarnet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCarnet.Click += new System.EventHandler(this.menuCarnet_Click);
            // 
            // menuActividad
            // 
            this.menuActividad.IconChar = FontAwesome.Sharp.IconChar.List;
            this.menuActividad.IconColor = System.Drawing.Color.Black;
            this.menuActividad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuActividad.IconSize = 35;
            this.menuActividad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuActividad.Name = "menuActividad";
            this.menuActividad.Size = new System.Drawing.Size(69, 54);
            this.menuActividad.Text = "Actividad";
            this.menuActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuActividad.Click += new System.EventHandler(this.menuActividad_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Silver;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 97);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(770, 450);
            this.pnlContenedor.TabIndex = 7;
            // 
            // frmPanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 547);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTop);
            this.MaximumSize = new System.Drawing.Size(786, 586);
            this.MinimumSize = new System.Drawing.Size(786, 586);
            this.Name = "frmPanelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administrador";
            this.Load += new System.EventHandler(this.frmPanelAdministrador_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip pnlMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnCerrarSesionAdmin;
        private FontAwesome.Sharp.IconMenuItem menuCarnet;
        private FontAwesome.Sharp.IconMenuItem menuActividad;
        private FontAwesome.Sharp.IconButton btnAjustes;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem subMenuNuevoRegistro;
        private System.Windows.Forms.ToolStripMenuItem subMenuHorarios;
        private FontAwesome.Sharp.IconMenuItem menuAsistencias;
        private FontAwesome.Sharp.IconMenuItem menuPagos;
        private FontAwesome.Sharp.IconMenuItem subMenuPagos;
        private FontAwesome.Sharp.IconMenuItem subMenuDeducciones;
        private FontAwesome.Sharp.IconMenuItem menuNominas;
    }
}