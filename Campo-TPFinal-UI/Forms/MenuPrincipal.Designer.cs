namespace Campo_TPFinal_UI
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LenguajeLabel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGestionIdioma = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAlquilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlquilar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAlquilar.FlatAppearance.BorderSize = 0;
            this.btnAlquilar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlquilar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlquilar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlquilar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlquilar.Image")));
            this.btnAlquilar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlquilar.Location = new System.Drawing.Point(0, 128);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(183, 62);
            this.btnAlquilar.TabIndex = 0;
            this.btnAlquilar.Tag = "btnAlquilar";
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.CausesValidation = false;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(0, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(186, 52);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Tag = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPerfil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.Location = new System.Drawing.Point(230, 166);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(183, 68);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Tag = "btnPerfil";
            this.btnPerfil.Text = "Gestion de Perfiles";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Visible = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.Location = new System.Drawing.Point(489, 166);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(183, 68);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Tag = "btnUsuarios";
            this.btnUsuarios.Text = "Gestion de Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Visible = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.LenguajeLabel);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAlquilar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 538);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LenguajeLabel
            // 
            this.LenguajeLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.LenguajeLabel.CausesValidation = false;
            this.LenguajeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LenguajeLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LenguajeLabel.ForeColor = System.Drawing.Color.White;
            this.LenguajeLabel.Image = ((System.Drawing.Image)(resources.GetObject("LenguajeLabel.Image")));
            this.LenguajeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LenguajeLabel.Location = new System.Drawing.Point(0, 434);
            this.LenguajeLabel.Name = "LenguajeLabel";
            this.LenguajeLabel.Size = new System.Drawing.Size(186, 52);
            this.LenguajeLabel.TabIndex = 5;
            this.LenguajeLabel.Tag = "LenguajeLabel";
            this.LenguajeLabel.Text = "LenguajeLabel";
            this.LenguajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LenguajeLabel.UseVisualStyleBackColor = false;
            this.LenguajeLabel.Click += new System.EventHandler(this.LenguajeLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 122);
            this.panel2.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(54, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 30);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(404, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tutú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(404, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carsharing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(591, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnGestionIdioma
            // 
            this.btnGestionIdioma.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGestionIdioma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGestionIdioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionIdioma.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionIdioma.Image")));
            this.btnGestionIdioma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionIdioma.Location = new System.Drawing.Point(230, 287);
            this.btnGestionIdioma.Name = "btnGestionIdioma";
            this.btnGestionIdioma.Size = new System.Drawing.Size(183, 68);
            this.btnGestionIdioma.TabIndex = 9;
            this.btnGestionIdioma.Tag = "btnGestionIdioma";
            this.btnGestionIdioma.Text = "btnGestionIdioma";
            this.btnGestionIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionIdioma.UseVisualStyleBackColor = false;
            this.btnGestionIdioma.Visible = false;
            this.btnGestionIdioma.Click += new System.EventHandler(this.btnGestionIdioma_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(795, 538);
            this.Controls.Add(this.btnGestionIdioma);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAlquilar;
        private Button btnSalir;
        private Button btnPerfil;
        private Button btnUsuarios;
        private Panel panel1;
        private Panel panel2;
        private Label lblUserName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button LenguajeLabel;
        private Button btnGestionIdioma;
    }
}