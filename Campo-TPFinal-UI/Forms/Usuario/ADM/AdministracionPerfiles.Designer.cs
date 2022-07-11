namespace Campo_TPFinal_UI
{
    partial class AdministracionPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionPerfiles));
            this.lstFamilia = new System.Windows.Forms.ListBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstPatente = new System.Windows.Forms.ListBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFamilia
            // 
            this.lstFamilia.FormattingEnabled = true;
            this.lstFamilia.ItemHeight = 15;
            this.lstFamilia.Location = new System.Drawing.Point(12, 41);
            this.lstFamilia.Name = "lstFamilia";
            this.lstFamilia.Size = new System.Drawing.Size(120, 154);
            this.lstFamilia.TabIndex = 0;
            this.lstFamilia.SelectedIndexChanged += new System.EventHandler(this.lstFamilia_SelectedIndexChanged);
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFamilia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFamilia.Location = new System.Drawing.Point(12, 9);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(48, 25);
            this.lblFamilia.TabIndex = 1;
            this.lblFamilia.Tag = "lblFamilia";
            this.lblFamilia.Text = "ROL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(8, 380);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Tag = "btnCrear";
            this.btnCrear.Text = "button1";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(138, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Tag = "btnEditar";
            this.btnEditar.Text = "button2";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(283, 380);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Tag = "btnBorrar";
            this.btnBorrar.Text = "button3";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lstPatente
            // 
            this.lstPatente.FormattingEnabled = true;
            this.lstPatente.ItemHeight = 15;
            this.lstPatente.Location = new System.Drawing.Point(163, 235);
            this.lstPatente.Name = "lstPatente";
            this.lstPatente.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPatente.Size = new System.Drawing.Size(200, 139);
            this.lstPatente.TabIndex = 7;
            this.lstPatente.SelectedIndexChanged += new System.EventHandler(this.lstPatente_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(18, 306);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(18, 278);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTipo.Size = new System.Drawing.Size(65, 25);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Tag = "lblTipo";
            this.lblTipo.Text = "label2";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(18, 207);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombre.Size = new System.Drawing.Size(65, 25);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Tag = "labelNombre";
            this.labelNombre.Text = "label2";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoles.Location = new System.Drawing.Point(163, 207);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoles.Size = new System.Drawing.Size(65, 25);
            this.lblRoles.TabIndex = 13;
            this.lblRoles.Tag = "lblRoles";
            this.lblRoles.Text = "label2";
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(138, 41);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(220, 154);
            this.treeConfigurarFamilia.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AdministracionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(375, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeConfigurarFamilia);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lstPatente);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lstFamilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministracionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutú Carsharing";
            this.Load += new System.EventHandler(this.AdministracionPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstFamilia;
        private Label lblFamilia;
        private TextBox textBox1;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnBorrar;
        private ListBox lstPatente;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private Label labelNombre;
        private Label lblRoles;
        private TreeView treeConfigurarFamilia;
        private PictureBox pictureBox1;
    }
}