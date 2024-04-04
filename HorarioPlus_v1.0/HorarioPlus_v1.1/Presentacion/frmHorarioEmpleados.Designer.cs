namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmHorarioEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTablaEntrada = new System.Windows.Forms.DataGridView();
            this.n_Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtsegundosEntrada = new System.Windows.Forms.TextBox();
            this.txtminutosEntrada = new System.Windows.Forms.TextBox();
            this.txtHorasEntrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtminutosSalida = new System.Windows.Forms.TextBox();
            this.txtsegundosSalida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEntrada)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.dgvTablaEntrada);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 422);
            this.panel1.TabIndex = 3;
            // 
            // dgvTablaEntrada
            // 
            this.dgvTablaEntrada.AllowUserToAddRows = false;
            this.dgvTablaEntrada.AllowUserToDeleteRows = false;
            this.dgvTablaEntrada.AllowUserToResizeColumns = false;
            this.dgvTablaEntrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvTablaEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTablaEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTablaEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTablaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_Empleados,
            this.HoraE,
            this.HorasS});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaEntrada.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTablaEntrada.EnableHeadersVisualStyles = false;
            this.dgvTablaEntrada.Location = new System.Drawing.Point(307, 52);
            this.dgvTablaEntrada.MultiSelect = false;
            this.dgvTablaEntrada.Name = "dgvTablaEntrada";
            this.dgvTablaEntrada.ReadOnly = true;
            this.dgvTablaEntrada.RowHeadersVisible = false;
            this.dgvTablaEntrada.RowHeadersWidth = 62;
            this.dgvTablaEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTablaEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaEntrada.Size = new System.Drawing.Size(362, 341);
            this.dgvTablaEntrada.TabIndex = 22;
            this.dgvTablaEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaEntrada_CellContentClick);
            // 
            // n_Empleados
            // 
            this.n_Empleados.HeaderText = "N°Empleados";
            this.n_Empleados.MinimumWidth = 10;
            this.n_Empleados.Name = "n_Empleados";
            this.n_Empleados.ReadOnly = true;
            this.n_Empleados.Width = 120;
            // 
            // HoraE
            // 
            this.HoraE.HeaderText = "Hora de Entrada";
            this.HoraE.MinimumWidth = 10;
            this.HoraE.Name = "HoraE";
            this.HoraE.ReadOnly = true;
            this.HoraE.Width = 120;
            // 
            // HorasS
            // 
            this.HorasS.HeaderText = "Hora de Salida";
            this.HorasS.MinimumWidth = 10;
            this.HorasS.Name = "HorasS";
            this.HorasS.ReadOnly = true;
            this.HorasS.Width = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 419);
            this.panel2.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(61, 388);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 28);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Controls.Add(this.txtsegundosEntrada);
            this.panel6.Controls.Add(this.txtminutosEntrada);
            this.panel6.Controls.Add(this.txtHorasEntrada);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(11, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 100);
            this.panel6.TabIndex = 2;
            // 
            // txtsegundosEntrada
            // 
            this.txtsegundosEntrada.Location = new System.Drawing.Point(177, 42);
            this.txtsegundosEntrada.MaxLength = 2;
            this.txtsegundosEntrada.Name = "txtsegundosEntrada";
            this.txtsegundosEntrada.Size = new System.Drawing.Size(31, 20);
            this.txtsegundosEntrada.TabIndex = 5;
            // 
            // txtminutosEntrada
            // 
            this.txtminutosEntrada.Location = new System.Drawing.Point(96, 42);
            this.txtminutosEntrada.MaxLength = 2;
            this.txtminutosEntrada.Name = "txtminutosEntrada";
            this.txtminutosEntrada.Size = new System.Drawing.Size(31, 20);
            this.txtminutosEntrada.TabIndex = 4;
            // 
            // txtHorasEntrada
            // 
            this.txtHorasEntrada.Location = new System.Drawing.Point(13, 42);
            this.txtHorasEntrada.MaxLength = 2;
            this.txtHorasEntrada.Name = "txtHorasEntrada";
            this.txtHorasEntrada.Size = new System.Drawing.Size(31, 20);
            this.txtHorasEntrada.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hora";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(11, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 42);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora de Salida";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CadetBlue;
            this.panel7.Controls.Add(this.txtHoraSalida);
            this.panel7.Controls.Add(this.txtminutosSalida);
            this.panel7.Controls.Add(this.txtsegundosSalida);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(11, 282);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(221, 100);
            this.panel7.TabIndex = 3;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(13, 43);
            this.txtHoraSalida.MaxLength = 2;
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(31, 20);
            this.txtHoraSalida.TabIndex = 6;
            this.txtHoraSalida.TextChanged += new System.EventHandler(this.txtHoraSalida_TextChanged);
            // 
            // txtminutosSalida
            // 
            this.txtminutosSalida.Location = new System.Drawing.Point(96, 43);
            this.txtminutosSalida.MaxLength = 2;
            this.txtminutosSalida.Name = "txtminutosSalida";
            this.txtminutosSalida.Size = new System.Drawing.Size(31, 20);
            this.txtminutosSalida.TabIndex = 6;
            // 
            // txtsegundosSalida
            // 
            this.txtsegundosSalida.Location = new System.Drawing.Point(177, 43);
            this.txtsegundosSalida.MaxLength = 2;
            this.txtsegundosSalida.Name = "txtsegundosSalida";
            this.txtsegundosSalida.Size = new System.Drawing.Size(31, 20);
            this.txtsegundosSalida.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Segundos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 47);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Jornada Laboral";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 42);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hora de Entrada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHorarioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHorarioEmpleados";
            this.Text = "frmHorarioEmpleados";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaEntrada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtsegundosEntrada;
        private System.Windows.Forms.TextBox txtminutosEntrada;
        private System.Windows.Forms.TextBox txtHorasEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.TextBox txtminutosSalida;
        private System.Windows.Forms.TextBox txtsegundosSalida;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTablaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasS;
    }
}