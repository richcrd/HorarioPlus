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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGenerarUno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarTodos = new System.Windows.Forms.Button();
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
            this.pnlCarnet.Location = new System.Drawing.Point(28, 90);
            this.pnlCarnet.Name = "pnlCarnet";
            this.pnlCarnet.Size = new System.Drawing.Size(694, 335);
            this.pnlCarnet.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(365, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnGenerarUno
            // 
            this.btnGenerarUno.Location = new System.Drawing.Point(471, 57);
            this.btnGenerarUno.Name = "btnGenerarUno";
            this.btnGenerarUno.Size = new System.Drawing.Size(75, 24);
            this.btnGenerarUno.TabIndex = 5;
            this.btnGenerarUno.Text = "Generar";
            this.btnGenerarUno.UseVisualStyleBackColor = true;
            this.btnGenerarUno.Click += new System.EventHandler(this.btnGenerarUno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el id:";
            // 
            // btnGenerarTodos
            // 
            this.btnGenerarTodos.BackColor = System.Drawing.Color.DarkGray;
            this.btnGenerarTodos.Location = new System.Drawing.Point(621, 57);
            this.btnGenerarTodos.Name = "btnGenerarTodos";
            this.btnGenerarTodos.Size = new System.Drawing.Size(101, 24);
            this.btnGenerarTodos.TabIndex = 7;
            this.btnGenerarTodos.Text = "Generar Todos";
            this.btnGenerarTodos.UseVisualStyleBackColor = false;
            this.btnGenerarTodos.Click += new System.EventHandler(this.btnGenerarTodos_Click);
            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarUno);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pnlCarnet);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCarnet";
            this.Text = "frmCarnet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel pnlCarnet;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGenerarUno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarTodos;
    }
}