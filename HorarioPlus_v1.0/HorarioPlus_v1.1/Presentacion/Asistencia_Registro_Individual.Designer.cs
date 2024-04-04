namespace HorarioPlus_v1._1.Presentacion
{
    partial class Asistencia_Registro_Individual
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
            this.btnLlegadaCorrecta = new System.Windows.Forms.Button();
            this.btnLlegadaTarde = new System.Windows.Forms.Button();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Crear_Excel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLlegadaCorrecta);
            this.panel1.Controls.Add(this.btnLlegadaTarde);
            this.panel1.Controls.Add(this.lblNombreEmpleado);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 118);
            this.panel1.TabIndex = 0;
            // 
            // btnLlegadaCorrecta
            // 
            this.btnLlegadaCorrecta.Location = new System.Drawing.Point(420, 92);
            this.btnLlegadaCorrecta.Name = "btnLlegadaCorrecta";
            this.btnLlegadaCorrecta.Size = new System.Drawing.Size(102, 23);
            this.btnLlegadaCorrecta.TabIndex = 3;
            this.btnLlegadaCorrecta.Text = "Llegada Correcta";
            this.btnLlegadaCorrecta.UseVisualStyleBackColor = true;
            this.btnLlegadaCorrecta.Click += new System.EventHandler(this.FiltrarCorrecto_Click);
            // 
            // btnLlegadaTarde
            // 
            this.btnLlegadaTarde.Location = new System.Drawing.Point(312, 92);
            this.btnLlegadaTarde.Name = "btnLlegadaTarde";
            this.btnLlegadaTarde.Size = new System.Drawing.Size(102, 23);
            this.btnLlegadaTarde.TabIndex = 3;
            this.btnLlegadaTarde.Text = "Llegada Tarde";
            this.btnLlegadaTarde.UseVisualStyleBackColor = true;
            this.btnLlegadaTarde.Click += new System.EventHandler(this.FiltrarTarde_Click);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(202, 44);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblNombreEmpleado.TabIndex = 1;
            this.lblNombreEmpleado.Text = "Empleado";
            this.lblNombreEmpleado.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros Cronometricos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deshacer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeshacerFiltro_Click);
            // 
            // BTN_Crear_Excel
            // 
            this.BTN_Crear_Excel.Location = new System.Drawing.Point(438, 424);
            this.BTN_Crear_Excel.Name = "BTN_Crear_Excel";
            this.BTN_Crear_Excel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Crear_Excel.TabIndex = 2;
            this.BTN_Crear_Excel.Text = "Crear Excel";
            this.BTN_Crear_Excel.UseVisualStyleBackColor = true;
            this.BTN_Crear_Excel.Click += new System.EventHandler(this.BTN_Crear_Excel_Click);
            // 
            // Asistencia_Registro_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.BTN_Crear_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Asistencia_Registro_Individual";
            this.Text = "Asistencia_Registro_Individual";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Button btnLlegadaTarde;
        private System.Windows.Forms.Button btnLlegadaCorrecta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Crear_Excel;
    }
}