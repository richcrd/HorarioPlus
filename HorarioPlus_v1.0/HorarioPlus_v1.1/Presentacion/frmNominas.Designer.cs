namespace HorarioPlus_v1._1.Presentacion
{
    partial class frmNominas
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
            this.btnGenerarPDF = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerarPDF.IconColor = System.Drawing.Color.Black;
            this.btnGenerarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarPDF.Location = new System.Drawing.Point(573, 71);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarPDF.TabIndex = 0;
            this.btnGenerarPDF.Text = "Imprimir";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            // 
            // frmNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarPDF);
            this.Name = "frmNominas";
            this.Text = "Nominas";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGenerarPDF;
    }
}