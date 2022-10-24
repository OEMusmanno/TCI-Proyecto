namespace Campo_TPFinal_UI.Forms.SolicitudDeCompra
{
    partial class SolicitudDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudDeCompra));
            this.grdSolicitud = new System.Windows.Forms.DataGridView();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.MarcaTxt = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.modeloTxt = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.precioUnitarioText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAgregar = new System.Windows.Forms.Button();
            this.txtPrecioUnitario = new System.Windows.Forms.Label();
            this.cantidadText = new System.Windows.Forms.TextBox();
            this.cmbTipoCambio = new System.Windows.Forms.ComboBox();
            this.txtTipoCambio = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.txtTipoPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpSolicitudCompra = new System.Windows.Forms.GroupBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.grpSolicitudCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSolicitud
            // 
            this.grdSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSolicitud.Location = new System.Drawing.Point(12, 252);
            this.grdSolicitud.Name = "grdSolicitud";
            this.grdSolicitud.RowTemplate.Height = 25;
            this.grdSolicitud.Size = new System.Drawing.Size(886, 319);
            this.grdSolicitud.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(302, 52);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(142, 23);
            this.cmbTipo.TabIndex = 3;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(302, 28);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(131, 21);
            this.lblTipoVehiculo.TabIndex = 56;
            this.lblTipoVehiculo.Tag = "lblTipoVehiculo";
            this.lblTipoVehiculo.Text = "lblTipoVehiculo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(6, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(77, 21);
            this.lblMarca.TabIndex = 55;
            this.lblMarca.Tag = "lblMarca";
            this.lblMarca.Text = "lblMarca";
            // 
            // MarcaTxt
            // 
            this.MarcaTxt.Location = new System.Drawing.Point(6, 52);
            this.MarcaTxt.Name = "MarcaTxt";
            this.MarcaTxt.Size = new System.Drawing.Size(142, 23);
            this.MarcaTxt.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModelo.Location = new System.Drawing.Point(154, 28);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(89, 21);
            this.lblModelo.TabIndex = 52;
            this.lblModelo.Tag = "lblModelo";
            this.lblModelo.Text = "lblModelo";
            // 
            // modeloTxt
            // 
            this.modeloTxt.Location = new System.Drawing.Point(154, 52);
            this.modeloTxt.Name = "modeloTxt";
            this.modeloTxt.Size = new System.Drawing.Size(142, 23);
            this.modeloTxt.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.Location = new System.Drawing.Point(155, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 21);
            this.txtCantidad.TabIndex = 59;
            this.txtCantidad.Tag = "txtCantidad";
            this.txtCantidad.Text = "txtCantidad";
            // 
            // precioUnitarioText
            // 
            this.precioUnitarioText.Location = new System.Drawing.Point(7, 43);
            this.precioUnitarioText.Name = "precioUnitarioText";
            this.precioUnitarioText.Size = new System.Drawing.Size(142, 23);
            this.precioUnitarioText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.modeloTxt);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.MarcaTxt);
            this.groupBox1.Controls.Add(this.lblTipoVehiculo);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 93);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // txtAgregar
            // 
            this.txtAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.txtAgregar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAgregar.Image = ((System.Drawing.Image)(resources.GetObject("txtAgregar.Image")));
            this.txtAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtAgregar.Location = new System.Drawing.Point(683, 169);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(215, 64);
            this.txtAgregar.TabIndex = 8;
            this.txtAgregar.Tag = "txtAgregar";
            this.txtAgregar.Text = "txtAgregar";
            this.txtAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAgregar.UseVisualStyleBackColor = false;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AutoSize = true;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioUnitario.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(7, 19);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(142, 21);
            this.txtPrecioUnitario.TabIndex = 62;
            this.txtPrecioUnitario.Tag = "txtPrecioUnitario";
            this.txtPrecioUnitario.Text = "txtPrecioUnitario";
            // 
            // cantidadText
            // 
            this.cantidadText.Location = new System.Drawing.Point(173, 43);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(57, 23);
            this.cantidadText.TabIndex = 5;
            // 
            // cmbTipoCambio
            // 
            this.cmbTipoCambio.FormattingEnabled = true;
            this.cmbTipoCambio.Location = new System.Drawing.Point(262, 43);
            this.cmbTipoCambio.Name = "cmbTipoCambio";
            this.cmbTipoCambio.Size = new System.Drawing.Size(142, 23);
            this.cmbTipoCambio.TabIndex = 6;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.AutoSize = true;
            this.txtTipoCambio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTipoCambio.Location = new System.Drawing.Point(262, 19);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(124, 21);
            this.txtTipoCambio.TabIndex = 63;
            this.txtTipoCambio.Tag = "txtTipoCambio";
            this.txtTipoCambio.Text = "txtTipoCambio";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.txtTipoPago);
            this.grpPago.Controls.Add(this.cmbTipoPago);
            this.grpPago.Controls.Add(this.txtTipoCambio);
            this.grpPago.Controls.Add(this.cmbTipoCambio);
            this.grpPago.Controls.Add(this.precioUnitarioText);
            this.grpPago.Controls.Add(this.txtCantidad);
            this.grpPago.Controls.Add(this.cantidadText);
            this.grpPago.Controls.Add(this.txtPrecioUnitario);
            this.grpPago.Location = new System.Drawing.Point(9, 121);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(600, 72);
            this.grpPago.TabIndex = 65;
            this.grpPago.TabStop = false;
            this.grpPago.Tag = "grpPago";
            this.grpPago.Text = "grpPago";
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.AutoSize = true;
            this.txtTipoPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipoPago.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTipoPago.Location = new System.Drawing.Point(422, 19);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(104, 21);
            this.txtTipoPago.TabIndex = 65;
            this.txtTipoPago.Tag = "txtTipoPago";
            this.txtTipoPago.Text = "txtTipoPago";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(422, 43);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(142, 23);
            this.cmbTipoPago.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(683, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 64);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Tag = "btnLimpiar";
            this.btnLimpiar.Text = "btnLimpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpSolicitudCompra
            // 
            this.grpSolicitudCompra.Controls.Add(this.groupBox1);
            this.grpSolicitudCompra.Controls.Add(this.grpPago);
            this.grpSolicitudCompra.Location = new System.Drawing.Point(12, 12);
            this.grpSolicitudCompra.Name = "grpSolicitudCompra";
            this.grpSolicitudCompra.Size = new System.Drawing.Size(650, 221);
            this.grpSolicitudCompra.TabIndex = 67;
            this.grpSolicitudCompra.TabStop = false;
            this.grpSolicitudCompra.Tag = "grpSolicitudCompra";
            this.grpSolicitudCompra.Text = "grpSolicitudCompra";
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSolicitar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolicitar.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitar.Image")));
            this.btnSolicitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitar.Location = new System.Drawing.Point(462, 598);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(215, 64);
            this.btnSolicitar.TabIndex = 9;
            this.btnSolicitar.Tag = "btnSolicitar";
            this.btnSolicitar.Text = "btnSolicitar";
            this.btnSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(683, 598);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 64);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Tag = "btnCancelar";
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 67;
            this.label1.Tag = "";
            this.label1.Text = "Total: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Location = new System.Drawing.Point(203, 605);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(35, 41);
            this.txtTotal.TabIndex = 70;
            this.txtTotal.Tag = "";
            this.txtTotal.Text = "0";
            // 
            // SolicitudDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(923, 674);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.grpSolicitudCompra);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdSolicitud);
            this.Controls.Add(this.txtAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitudDeCompra";
            this.Text = "Tutu CarSharing";
            this.Load += new System.EventHandler(this.SolicitudDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.grpSolicitudCompra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView grdSolicitud;
        private ComboBox cmbTipo;
        private Label lblTipoVehiculo;
        private Label lblMarca;
        private TextBox MarcaTxt;
        private Label lblModelo;
        private TextBox modeloTxt;
        private Label txtCantidad;
        private TextBox precioUnitarioText;
        private GroupBox groupBox1;
        private Label txtPrecioUnitario;
        private TextBox cantidadText;
        private Button txtAgregar;
        private ComboBox cmbTipoCambio;
        private Label txtTipoCambio;
        private GroupBox grpPago;
        private Label txtTipoPago;
        private ComboBox cmbTipoPago;
        private Button btnLimpiar;
        private GroupBox grpSolicitudCompra;
        private Button btnSolicitar;
        private Button btnCancelar;
        private Label label1;
        private Label txtTotal;
    }
}