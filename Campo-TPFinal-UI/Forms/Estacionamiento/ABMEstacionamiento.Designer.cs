namespace Campo_TPFinal_UI.Forms.Estacionamiento
{
    partial class ABMEstacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMEstacionamiento));
            this.ubicacionTxt = new System.Windows.Forms.TextBox();
            this.espacioTxt = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.lstEstacionamiento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lstEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // ubicacionTxt
            // 
            this.ubicacionTxt.Location = new System.Drawing.Point(12, 96);
            this.ubicacionTxt.Name = "ubicacionTxt";
            this.ubicacionTxt.Size = new System.Drawing.Size(142, 23);
            this.ubicacionTxt.TabIndex = 0;
            // 
            // espacioTxt
            // 
            this.espacioTxt.Location = new System.Drawing.Point(12, 146);
            this.espacioTxt.Name = "espacioTxt";
            this.espacioTxt.Size = new System.Drawing.Size(142, 23);
            this.espacioTxt.TabIndex = 1;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUbicacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUbicacion.Location = new System.Drawing.Point(12, 72);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(107, 21);
            this.lblUbicacion.TabIndex = 25;
            this.lblUbicacion.Tag = "lblUbicacion";
            this.lblUbicacion.Text = "lblUbicacion";
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspacio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEspacio.Location = new System.Drawing.Point(12, 122);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(88, 21);
            this.lblEspacio.TabIndex = 26;
            this.lblEspacio.Tag = "lblEspacio";
            this.lblEspacio.Text = "lblEspacio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(12, 307);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 32);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Tag = "btnLimpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(12, 269);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 32);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Tag = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(12, 231);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 32);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Tag = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(12, 193);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(142, 32);
            this.btnCrear.TabIndex = 28;
            this.btnCrear.Tag = "btnCrear";
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 35;
            this.label3.Tag = "lblUsuarios";
            this.label3.Text = "Id";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(12, 46);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(142, 23);
            this.idText.TabIndex = 34;
            // 
            // lstEstacionamiento
            // 
            this.lstEstacionamiento.AllowUserToAddRows = false;
            this.lstEstacionamiento.AllowUserToDeleteRows = false;
            this.lstEstacionamiento.AllowUserToResizeColumns = false;
            this.lstEstacionamiento.AllowUserToResizeRows = false;
            this.lstEstacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEstacionamiento.Location = new System.Drawing.Point(183, 46);
            this.lstEstacionamiento.MultiSelect = false;
            this.lstEstacionamiento.Name = "lstEstacionamiento";
            this.lstEstacionamiento.ReadOnly = true;
            this.lstEstacionamiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lstEstacionamiento.RowTemplate.Height = 25;
            this.lstEstacionamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstEstacionamiento.Size = new System.Drawing.Size(399, 293);
            this.lstEstacionamiento.TabIndex = 36;
            this.lstEstacionamiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstEstacionamiento_CellClick);
            // 
            // ABMEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(594, 363);
            this.Controls.Add(this.lstEstacionamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.espacioTxt);
            this.Controls.Add(this.ubicacionTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMEstacionamiento";
            this.Text = "Tutu CarSharing";
            this.Load += new System.EventHandler(this.ABMEstacionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstEstacionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ubicacionTxt;
        private TextBox espacioTxt;
        private Label lblUbicacion;
        private Label lblEspacio;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnCrear;
        private Label label3;
        private TextBox idText;
        private DataGridView lstEstacionamiento;
    }
}