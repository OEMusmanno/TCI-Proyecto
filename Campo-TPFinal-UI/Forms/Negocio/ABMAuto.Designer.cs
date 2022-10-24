namespace Campo_TPFinal_UI.Forms.Negocio
{
    partial class ABMAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMAuto));
            this.label3 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.modeloTxt = new System.Windows.Forms.TextBox();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.grdAuto = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grdEstacionamiento = new System.Windows.Forms.DataGridView();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtBloqueado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 41;
            this.label3.Tag = "lblUsuarios";
            this.label3.Text = "Id";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(12, 38);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(142, 23);
            this.idText.TabIndex = 40;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Location = new System.Drawing.Point(12, 114);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(89, 21);
            this.lblModelo.TabIndex = 39;
            this.lblModelo.Tag = "lblModelo";
            this.lblModelo.Text = "lblModelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(12, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(77, 21);
            this.lblMarca.TabIndex = 38;
            this.lblMarca.Tag = "lblMarca";
            this.lblMarca.Text = "lblMarca";
            // 
            // modeloTxt
            // 
            this.modeloTxt.Location = new System.Drawing.Point(12, 138);
            this.modeloTxt.Name = "modeloTxt";
            this.modeloTxt.Size = new System.Drawing.Size(142, 23);
            this.modeloTxt.TabIndex = 37;
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(12, 88);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(142, 23);
            this.marcaTxt.TabIndex = 36;
            // 
            // grdAuto
            // 
            this.grdAuto.AllowUserToAddRows = false;
            this.grdAuto.AllowUserToDeleteRows = false;
            this.grdAuto.AllowUserToResizeColumns = false;
            this.grdAuto.AllowUserToResizeRows = false;
            this.grdAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAuto.Location = new System.Drawing.Point(176, 14);
            this.grdAuto.MultiSelect = false;
            this.grdAuto.Name = "grdAuto";
            this.grdAuto.ReadOnly = true;
            this.grdAuto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAuto.RowTemplate.Height = 25;
            this.grdAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAuto.Size = new System.Drawing.Size(536, 384);
            this.grdAuto.TabIndex = 42;
            this.grdAuto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAuto_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(12, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 32);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Tag = "btnLimpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(12, 328);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 32);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Tag = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(12, 290);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 32);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Tag = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(12, 252);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(142, 32);
            this.btnCrear.TabIndex = 43;
            this.btnCrear.Tag = "btnCrear";
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // grdEstacionamiento
            // 
            this.grdEstacionamiento.AllowUserToAddRows = false;
            this.grdEstacionamiento.AllowUserToDeleteRows = false;
            this.grdEstacionamiento.AllowUserToResizeColumns = false;
            this.grdEstacionamiento.AllowUserToResizeRows = false;
            this.grdEstacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstacionamiento.Location = new System.Drawing.Point(718, 14);
            this.grdEstacionamiento.MultiSelect = false;
            this.grdEstacionamiento.Name = "grdEstacionamiento";
            this.grdEstacionamiento.ReadOnly = true;
            this.grdEstacionamiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEstacionamiento.RowTemplate.Height = 25;
            this.grdEstacionamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEstacionamiento.Size = new System.Drawing.Size(373, 384);
            this.grdEstacionamiento.TabIndex = 47;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 164);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(131, 21);
            this.lblTipoVehiculo.TabIndex = 48;
            this.lblTipoVehiculo.Tag = "lblTipoVehiculo";
            this.lblTipoVehiculo.Text = "lblTipoVehiculo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 188);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(142, 23);
            this.cmbTipo.TabIndex = 49;
            // 
            // txtBloqueado
            // 
            this.txtBloqueado.AutoSize = true;
            this.txtBloqueado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBloqueado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBloqueado.Location = new System.Drawing.Point(12, 217);
            this.txtBloqueado.Name = "txtBloqueado";
            this.txtBloqueado.Size = new System.Drawing.Size(133, 25);
            this.txtBloqueado.TabIndex = 50;
            this.txtBloqueado.Tag = "txtBloqueado";
            this.txtBloqueado.Text = "txtBloqueado";
            this.txtBloqueado.UseVisualStyleBackColor = true;
            // 
            // ABMAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1099, 429);
            this.Controls.Add(this.txtBloqueado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.grdEstacionamiento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.grdAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.modeloTxt);
            this.Controls.Add(this.marcaTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMAuto";
            this.Text = "Tutú Carsharing";
            this.Load += new System.EventHandler(this.ABMAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstacionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox idText;
        private Label lblModelo;
        private Label lblMarca;
        private TextBox modeloTxt;
        private TextBox marcaTxt;
        private DataGridView grdAuto;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnCrear;
        private DataGridView grdEstacionamiento;
        private Label lblTipoVehiculo;
        private ComboBox cmbTipo;
        private CheckBox txtBloqueado;
    }
}