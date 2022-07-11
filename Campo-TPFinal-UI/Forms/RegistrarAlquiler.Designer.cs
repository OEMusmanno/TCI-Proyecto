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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAlquiler));
            this.grdListadoAutos = new System.Windows.Forms.DataGridView();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.lblTipoVehiculo1 = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblModelo1 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.brnFinalizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAlquiler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListadoAutos
            // 
            this.grdListadoAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListadoAutos.Location = new System.Drawing.Point(21, 85);
            this.grdListadoAutos.Name = "grdListadoAutos";
            this.grdListadoAutos.RowTemplate.Height = 25;
            this.grdListadoAutos.Size = new System.Drawing.Size(1063, 172);
            this.grdListadoAutos.TabIndex = 0;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlquiler.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAlquiler.Location = new System.Drawing.Point(12, 9);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(392, 65);
            this.lblAlquiler.TabIndex = 1;
            this.lblAlquiler.Tag = "lblAlquiler";
            this.lblAlquiler.Text = "Registrar Alquiler";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAlquilar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlquilar.ForeColor = System.Drawing.Color.Ivory;
            this.btnAlquilar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlquilar.Image")));
            this.btnAlquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlquilar.Location = new System.Drawing.Point(21, 279);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(282, 75);
            this.btnAlquilar.TabIndex = 2;
            this.btnAlquilar.Tag = "btnAlquilar";
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTipoVehiculo1
            // 
            this.lblTipoVehiculo1.AutoSize = true;
            this.lblTipoVehiculo1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoVehiculo1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoVehiculo1.Location = new System.Drawing.Point(23, 251);
            this.lblTipoVehiculo1.Name = "lblTipoVehiculo1";
            this.lblTipoVehiculo1.Size = new System.Drawing.Size(64, 25);
            this.lblTipoVehiculo1.TabIndex = 5;
            this.lblTipoVehiculo1.Text = "label6";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(23, 222);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(61, 25);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Tag = "lblTipoVehiculo";
            this.lblTipoVehiculo.Text = "label1";
            // 
            // lblModelo1
            // 
            this.lblModelo1.AutoSize = true;
            this.lblModelo1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo1.Location = new System.Drawing.Point(23, 182);
            this.lblModelo1.Name = "lblModelo1";
            this.lblModelo1.Size = new System.Drawing.Size(61, 25);
            this.lblModelo1.TabIndex = 3;
            this.lblModelo1.Text = "label1";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Location = new System.Drawing.Point(23, 153);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 25);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Tag = "lblModelo";
            this.lblModelo.Text = "label1";
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca1.Location = new System.Drawing.Point(23, 114);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(61, 25);
            this.lblMarca1.TabIndex = 1;
            this.lblMarca1.Text = "label1";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(23, 85);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 25);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Tag = "lblMarca";
            this.lblMarca.Text = "label1";
            // 
            // brnFinalizar
            // 
            this.brnFinalizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnFinalizar.ForeColor = System.Drawing.Color.DarkBlue;
            this.brnFinalizar.Location = new System.Drawing.Point(252, 114);
            this.brnFinalizar.Name = "brnFinalizar";
            this.brnFinalizar.Size = new System.Drawing.Size(282, 73);
            this.brnFinalizar.TabIndex = 4;
            this.brnFinalizar.Tag = "brnFinalizar";
            this.brnFinalizar.Text = "Alquilar";
            this.brnFinalizar.UseVisualStyleBackColor = true;
            this.brnFinalizar.Click += new System.EventHandler(this.brnFinalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // grpAlquiler
            // 
            this.grpAlquiler.AutoSize = true;
            this.grpAlquiler.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAlquiler.ForeColor = System.Drawing.SystemColors.Control;
            this.grpAlquiler.Location = new System.Drawing.Point(12, 9);
            this.grpAlquiler.Name = "grpAlquiler";
            this.grpAlquiler.Size = new System.Drawing.Size(392, 65);
            this.grpAlquiler.TabIndex = 7;
            this.grpAlquiler.Tag = "grpAlquiler";
            this.grpAlquiler.Text = "Registrar Alquiler";
            // 
            // RegistrarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1096, 402);
            this.Controls.Add(this.brnFinalizar);
            this.Controls.Add(this.lblTipoVehiculo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAlquiler);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo1);
            this.Controls.Add(this.lblAlquiler);
            this.Controls.Add(this.lblMarca1);
            this.Controls.Add(this.grdListadoAutos);
            this.Controls.Add(this.lblModelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarAlquiler";
            this.Text = "Tutu CarSharing";
            this.Load += new System.EventHandler(this.RegistrarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdListadoAutos;
        private Label lblAlquiler;
        private Button btnAlquilar;
        private Label lblMarca;
        private Button brnFinalizar;
        private Label lblTipoVehiculo1;
        private Label lblTipoVehiculo;
        private Label lblModelo1;
        private Label lblModelo;
        private Label lblMarca1;
        private PictureBox pictureBox1;
        private Label grpAlquiler;
    }
}