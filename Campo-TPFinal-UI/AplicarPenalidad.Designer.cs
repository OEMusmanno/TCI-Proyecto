namespace Campo_TPFinal_UI
{
    partial class AplicarPenalidad
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
            this.grdListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPenalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListadoUsuarios
            // 
            this.grdListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListadoUsuarios.Location = new System.Drawing.Point(33, 89);
            this.grdListadoUsuarios.Name = "grdListadoUsuarios";
            this.grdListadoUsuarios.RowTemplate.Height = 25;
            this.grdListadoUsuarios.Size = new System.Drawing.Size(240, 150);
            this.grdListadoUsuarios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPenalidad
            // 
            this.cmbPenalidad.FormattingEnabled = true;
            this.cmbPenalidad.Location = new System.Drawing.Point(33, 263);
            this.cmbPenalidad.Name = "cmbPenalidad";
            this.cmbPenalidad.Size = new System.Drawing.Size(121, 23);
            this.cmbPenalidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Penalidades";
            // 
            // AplicarPenalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPenalidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdListadoUsuarios);
            this.Name = "AplicarPenalidad";
            this.Text = "AplicarPenalidad";
            this.Load += new System.EventHandler(this.AplicarPenalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdListadoUsuarios;
        private Button button1;
        private ComboBox cmbPenalidad;
        private Label label1;
    }
}