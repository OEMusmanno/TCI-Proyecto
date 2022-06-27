namespace Campo_TPFinal_UI
{
    partial class RegistrarAlquiler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdListadoAutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Alquilar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListadoAutos
            // 
            this.grdListadoAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListadoAutos.Location = new System.Drawing.Point(41, 53);
            this.grdListadoAutos.Name = "grdListadoAutos";
            this.grdListadoAutos.RowTemplate.Height = 25;
            this.grdListadoAutos.Size = new System.Drawing.Size(1013, 299);
            this.grdListadoAutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Alquiler";
            // 
            // Alquilar
            // 
            this.Alquilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Alquilar.ForeColor = System.Drawing.Color.LimeGreen;
            this.Alquilar.Location = new System.Drawing.Point(902, 358);
            this.Alquilar.Name = "Alquilar";
            this.Alquilar.Size = new System.Drawing.Size(152, 55);
            this.Alquilar.TabIndex = 2;
            this.Alquilar.Text = "Alquilar";
            this.Alquilar.UseVisualStyleBackColor = true;
            this.Alquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.Alquilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdListadoAutos);
            this.Name = "RegistrarAlquiler";
            this.Text = "Tutu - CarSharing";
            this.Load += new System.EventHandler(this.RegistrarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdListadoAutos;
        private Label label1;
        private Button Alquilar;
    }
}