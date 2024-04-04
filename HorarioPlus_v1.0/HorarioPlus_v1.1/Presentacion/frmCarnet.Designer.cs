namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmCarnet
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
            this.pnlCarnet = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet2 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtCarnet1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Carnets de Empleados";
            // 
            // pnlCarnet
            // 
            this.pnlCarnet.AutoScroll = true;
            this.pnlCarnet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCarnet.Location = new System.Drawing.Point(28, 103);
            this.pnlCarnet.Name = "pnlCarnet";
            this.pnlCarnet.Size = new System.Drawing.Size(694, 335);
            this.pnlCarnet.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(14, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(120, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Carnet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(249, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.ForeColor = System.Drawing.Color.Green;
            this.btnRefrescar.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnRefrescar.IconColor = System.Drawing.Color.Green;
            this.btnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefrescar.IconSize = 30;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.Location = new System.Drawing.Point(681, 38);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(41, 38);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCarnet2);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.txtCarnet1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(465, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 69);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // txtCarnet2
            // 
            this.txtCarnet2.Location = new System.Drawing.Point(74, 34);
            this.txtCarnet2.Name = "txtCarnet2";
            this.txtCarnet2.Size = new System.Drawing.Size(40, 20);
            this.txtCarnet2.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(120, 31);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 24);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // txtCarnet1
            // 
            this.txtCarnet1.Location = new System.Drawing.Point(14, 34);
            this.txtCarnet1.Name = "txtCarnet1";
            this.txtCarnet1.Size = new System.Drawing.Size(40, 20);
            this.txtCarnet1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar Carnets";
            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCarnet);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCarnet";
            this.Text = "frmCarnet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel pnlCarnet;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtCarnet1;
        private System.Windows.Forms.Label label2;
    }
}