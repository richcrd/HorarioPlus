namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMarcarRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleadoId = new System.Windows.Forms.TextBox();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(452, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Por favor, ingrese su ID de empleado tal como aparece en su carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(178, 36);
            this.label2.MinimumSize = new System.Drawing.Size(178, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "REGISTRO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 450);
            this.panel1.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHora.Location = new System.Drawing.Point(47, 346);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(308, 60);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "07: 55: 30 AM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMarcarRegistro
            // 
            this.btnMarcarRegistro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMarcarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarRegistro.Location = new System.Drawing.Point(460, 346);
            this.btnMarcarRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMarcarRegistro.Name = "btnMarcarRegistro";
            this.btnMarcarRegistro.Size = new System.Drawing.Size(130, 55);
            this.btnMarcarRegistro.TabIndex = 9;
            this.btnMarcarRegistro.Text = "Marcar";
            this.btnMarcarRegistro.UseVisualStyleBackColor = false;
            this.btnMarcarRegistro.Click += new System.EventHandler(this.btnMarcarRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(172, 20);
            this.label1.MinimumSize = new System.Drawing.Size(172, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite su ID Empleado:";
            // 
            // txtEmpleadoId
            // 
            this.txtEmpleadoId.Location = new System.Drawing.Point(456, 275);
            this.txtEmpleadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpleadoId.MaximumSize = new System.Drawing.Size(234, 26);
            this.txtEmpleadoId.MinimumSize = new System.Drawing.Size(234, 26);
            this.txtEmpleadoId.Name = "txtEmpleadoId";
            this.txtEmpleadoId.Size = new System.Drawing.Size(234, 26);
            this.txtEmpleadoId.TabIndex = 7;
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMarcarRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleadoId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(819, 450);
            this.MinimumSize = new System.Drawing.Size(819, 450);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMarcarRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleadoId;
        private System.Windows.Forms.Timer timerHora;
    }
}