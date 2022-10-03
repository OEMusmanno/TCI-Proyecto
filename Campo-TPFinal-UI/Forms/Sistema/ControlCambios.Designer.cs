namespace Campo_TPFinal_UI.Forms.Sistema
{
    partial class ControlCambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCambios));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.grdListado = new System.Windows.Forms.DataGridView();
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.txtVersionado = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(390, 43);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(183, 68);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Tag = "btnLimpiar";
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(27, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(65, 25);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Tag = "lblDescripcion";
            this.lblDescripcion.Text = "label3";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(27, 29);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(79, 25);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Tag = "lblStartDate";
            this.lblStartDate.Text = "Version";
            // 
            // grdListado
            // 
            this.grdListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListado.Location = new System.Drawing.Point(27, 371);
            this.grdListado.Name = "grdListado";
            this.grdListado.RowTemplate.Height = 25;
            this.grdListado.Size = new System.Drawing.Size(546, 149);
            this.grdListado.TabIndex = 24;
            this.grdListado.SelectionChanged += new System.EventHandler(this.grdListado_SelectionChanged);
            // 
            // descripcionText
            // 
            this.descripcionText.Enabled = false;
            this.descripcionText.Location = new System.Drawing.Point(27, 547);
            this.descripcionText.Multiline = true;
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(546, 157);
            this.descripcionText.TabIndex = 25;
            // 
            // txtVersionado
            // 
            this.txtVersionado.Location = new System.Drawing.Point(27, 69);
            this.txtVersionado.Name = "txtVersionado";
            this.txtVersionado.Size = new System.Drawing.Size(100, 23);
            this.txtVersionado.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(27, 133);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(546, 157);
            this.txtDescripcion.TabIndex = 27;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListado.Location = new System.Drawing.Point(27, 343);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(65, 25);
            this.lblListado.TabIndex = 28;
            this.lblListado.Tag = "lblListado";
            this.lblListado.Text = "label3";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.Location = new System.Drawing.Point(201, 43);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(183, 68);
            this.btnCrear.TabIndex = 29;
            this.btnCrear.Tag = "btnCrear";
            this.btnCrear.Text = "Guardar";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // ControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(597, 738);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtVersionado);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.grdListado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblStartDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutu CarSharing";
            this.Load += new System.EventHandler(this.ControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpiar;
        private Label lblDescripcion;
        private Label lblStartDate;
        private DataGridView grdListado;
        private TextBox descripcionText;
        private TextBox txtVersionado;
        private TextBox txtDescripcion;
        private Label lblListado;
        private Button btnCrear;
    }
}