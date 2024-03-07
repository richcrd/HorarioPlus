﻿namespace HorarioPlus_v1._1.Presentacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.MenuStrip();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.submenuNuevoRegistro = new FontAwesome.Sharp.IconMenuItem();
            this.submenuHorarioEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerrarSesionAdmin = new FontAwesome.Sharp.IconButton();
            this.btnAjustes = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(105, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 44);
            this.panel1.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(125, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(124, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador:";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightBlue;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.menuEmpleados,
            this.pagosToolStripMenuItem,
            this.nominasToolStripMenuItem,
            this.iconMenuItem1,
            this.iconMenuItem2});
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuPanel.Size = new System.Drawing.Size(105, 561);
            this.menuPanel.TabIndex = 4;
            this.menuPanel.Text = "menuStrip1";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuNuevoRegistro,
            this.submenuHorarioEmpleados});
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(96, 28);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submenuNuevoRegistro
            // 
            this.submenuNuevoRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuNuevoRegistro.IconColor = System.Drawing.Color.Black;
            this.submenuNuevoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuNuevoRegistro.Name = "submenuNuevoRegistro";
            this.submenuNuevoRegistro.Size = new System.Drawing.Size(180, 22);
            this.submenuNuevoRegistro.Text = "Nuevo Registro";
            this.submenuNuevoRegistro.Click += new System.EventHandler(this.submenuNuevoRegistro_Click);
            // 
            // submenuHorarioEmpleados
            // 
            this.submenuHorarioEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuHorarioEmpleados.IconColor = System.Drawing.Color.Black;
            this.submenuHorarioEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuHorarioEmpleados.Name = "submenuHorarioEmpleados";
            this.submenuHorarioEmpleados.Size = new System.Drawing.Size(180, 22);
            this.submenuHorarioEmpleados.Text = "Horarios Empleados";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagosToolStripMenuItem1,
            this.deduccionesToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // pagosToolStripMenuItem1
            // 
            this.pagosToolStripMenuItem1.Name = "pagosToolStripMenuItem1";
            this.pagosToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.pagosToolStripMenuItem1.Text = "Pagos";
            // 
            // deduccionesToolStripMenuItem
            // 
            this.deduccionesToolStripMenuItem.Name = "deduccionesToolStripMenuItem";
            this.deduccionesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deduccionesToolStripMenuItem.Text = "Deducciones";
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.nominasToolStripMenuItem.Text = "Nominas";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(96, 28);
            this.iconMenuItem1.Text = "Carnet";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(96, 28);
            this.iconMenuItem2.Text = "Actividad";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Silver;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(105, 44);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(779, 517);
            this.panelContenedor.TabIndex = 7;
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
            this.btnCerrarSesionAdmin.Location = new System.Drawing.Point(12, 511);
            this.btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin";
            this.btnCerrarSesionAdmin.Size = new System.Drawing.Size(70, 23);
            this.btnCerrarSesionAdmin.TabIndex = 8;
            this.btnCerrarSesionAdmin.Text = "Cerrar Sesion";
            this.btnCerrarSesionAdmin.UseVisualStyleBackColor = false;
            this.btnCerrarSesionAdmin.Click += new System.EventHandler(this.btnCerrarSesionAdmin_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Silver;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnAjustes.IconColor = System.Drawing.Color.White;
            this.btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjustes.IconSize = 15;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Location = new System.Drawing.Point(12, 475);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(70, 23);
            this.btnAjustes.TabIndex = 9;
            this.btnAjustes.Text = "Ajustes Sistema";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // frmPanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnCerrarSesionAdmin);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPanelAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administrador";
            this.Load += new System.EventHandler(this.frmPanelAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuPanel;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem submenuNuevoRegistro;
        private FontAwesome.Sharp.IconMenuItem submenuHorarioEmpleados;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnCerrarSesionAdmin;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconButton btnAjustes;
    }
}