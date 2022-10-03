namespace Campo_TPFinal_UI.Forms.Idioma
{
    partial class CambioIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioIdioma));
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbLenguaje = new System.Windows.Forms.ComboBox();
            this.LenguajeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 61);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Tag = "btnEditar";
            this.btnEditar.Text = "button1";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbLenguaje
            // 
            this.cmbLenguaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbLenguaje.FormattingEnabled = true;
            this.cmbLenguaje.Location = new System.Drawing.Point(0, 61);
            this.cmbLenguaje.Name = "cmbLenguaje";
            this.cmbLenguaje.Size = new System.Drawing.Size(140, 23);
            this.cmbLenguaje.TabIndex = 1;
            // 
            // LenguajeLabel
            // 
            this.LenguajeLabel.AutoSize = true;
            this.LenguajeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LenguajeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LenguajeLabel.Location = new System.Drawing.Point(12, 22);
            this.LenguajeLabel.Name = "LenguajeLabel";
            this.LenguajeLabel.Size = new System.Drawing.Size(57, 21);
            this.LenguajeLabel.TabIndex = 2;
            this.LenguajeLabel.Tag = "LenguajeLabel";
            this.LenguajeLabel.Text = "label1";
            // 
            // CambioIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(140, 145);
            this.Controls.Add(this.LenguajeLabel);
            this.Controls.Add(this.cmbLenguaje);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1100, 500);
            this.Name = "CambioIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tutú Carsharing";
            this.Load += new System.EventHandler(this.CambioIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditar;
        private ComboBox cmbLenguaje;
        private Label LenguajeLabel;
    }
}