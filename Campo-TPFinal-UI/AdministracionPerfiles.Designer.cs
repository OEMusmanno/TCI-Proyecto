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
            this.SuspendLayout();
            // 
            // lstFamilia
            // 
            this.lstFamilia.FormattingEnabled = true;
            this.lstFamilia.ItemHeight = 15;
            this.lstFamilia.Location = new System.Drawing.Point(12, 41);
            this.lstFamilia.Name = "lstFamilia";
            this.lstFamilia.Size = new System.Drawing.Size(120, 319);
            this.lstFamilia.TabIndex = 0;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFamilia.Location = new System.Drawing.Point(12, 9);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(48, 25);
            this.lblFamilia.TabIndex = 1;
            this.lblFamilia.Tag = "lblFamilia";
            this.lblFamilia.Text = "ROL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(138, 344);
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
            this.btnEditar.Location = new System.Drawing.Point(262, 344);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Tag = "btnEditar";
            this.btnEditar.Text = "button2";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(383, 344);
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
            this.lstPatente.Location = new System.Drawing.Point(138, 154);
            this.lstPatente.Name = "lstPatente";
            this.lstPatente.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPatente.Size = new System.Drawing.Size(318, 184);
            this.lstPatente.TabIndex = 7;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(337, 71);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(337, 43);
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
            this.labelNombre.Location = new System.Drawing.Point(138, 43);
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
            this.lblRoles.Location = new System.Drawing.Point(138, 126);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoles.Size = new System.Drawing.Size(65, 25);
            this.lblRoles.TabIndex = 13;
            this.lblRoles.Tag = "lblRoles";
            this.lblRoles.Text = "label2";
            // 
            // AdministracionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 416);
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
            this.Name = "AdministracionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Management";
            this.Load += new System.EventHandler(this.AdministracionPerfiles_Load);
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
    }
}