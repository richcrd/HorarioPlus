namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTablaPagos = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnImprimirNomina = new FontAwesome.Sharp.IconButton();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoPorHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasAcumuladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.dgvTablaPagos);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.btnImprimirNomina);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            // 
            // dgvTablaPagos
            // 
            this.dgvTablaPagos.AllowUserToAddRows = false;
            this.dgvTablaPagos.AllowUserToDeleteRows = false;
            this.dgvTablaPagos.AllowUserToResizeColumns = false;
            this.dgvTablaPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTablaPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTablaPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.Nombre,
            this.Apellido1,
            this.totalDeducciones,
            this.PagoPorHoras,
            this.HorasAcumuladas,
            this.pagoNeto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaPagos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaPagos.EnableHeadersVisualStyles = false;
            this.dgvTablaPagos.Location = new System.Drawing.Point(36, 121);
            this.dgvTablaPagos.MultiSelect = false;
            this.dgvTablaPagos.Name = "dgvTablaPagos";
            this.dgvTablaPagos.ReadOnly = true;
            this.dgvTablaPagos.RowHeadersVisible = false;
            this.dgvTablaPagos.RowHeadersWidth = 62;
            this.dgvTablaPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaPagos.Size = new System.Drawing.Size(661, 281);
            this.dgvTablaPagos.TabIndex = 23;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(614, 45);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(83, 23);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Text = "Recibo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalles Pagos";
            // 
            // btnImprimirNomina
            // 
            this.btnImprimirNomina.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImprimirNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirNomina.FlatAppearance.BorderSize = 0;
            this.btnImprimirNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirNomina.ForeColor = System.Drawing.Color.White;
            this.btnImprimirNomina.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirNomina.IconColor = System.Drawing.Color.White;
            this.btnImprimirNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirNomina.IconSize = 15;
            this.btnImprimirNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirNomina.Location = new System.Drawing.Point(525, 45);
            this.btnImprimirNomina.Name = "btnImprimirNomina";
            this.btnImprimirNomina.Size = new System.Drawing.Size(83, 23);
            this.btnImprimirNomina.TabIndex = 17;
            this.btnImprimirNomina.Text = "Nomina";
            this.btnImprimirNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirNomina.UseVisualStyleBackColor = false;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "ID";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdEmpleado.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 70;
            // 
            // Apellido1
            // 
            this.Apellido1.HeaderText = "Apellido 1";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            this.Apellido1.Width = 70;
            // 
            // totalDeducciones
            // 
            this.totalDeducciones.HeaderText = "Deducciones";
            this.totalDeducciones.Name = "totalDeducciones";
            this.totalDeducciones.ReadOnly = true;
            // 
            // PagoPorHoras
            // 
            this.PagoPorHoras.HeaderText = "Pago Horas";
            this.PagoPorHoras.Name = "PagoPorHoras";
            this.PagoPorHoras.ReadOnly = true;
            // 
            // HorasAcumuladas
            // 
            this.HorasAcumuladas.HeaderText = "Total Horas";
            this.HorasAcumuladas.Name = "HorasAcumuladas";
            this.HorasAcumuladas.ReadOnly = true;
            // 
            // pagoNeto
            // 
            this.pagoNeto.HeaderText = "Pago Neto";
            this.pagoNeto.Name = "pagoNeto";
            this.pagoNeto.ReadOnly = true;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "frmPagos";
            this.Text = "formulario Pagos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnImprimirNomina;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dgvTablaPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagoPorHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasAcumuladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoNeto;
    }
}