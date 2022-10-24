namespace Campo_TPFinal_UI.Forms.SolicitudDeCompra
{
    partial class RevisionDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionDeCompra));
            this.lstPendientes = new System.Windows.Forms.ListBox();
            this.grdSolicitud = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechazar = new System.Windows.Forms.Button();
            this.txtAprobar = new System.Windows.Forms.Button();
            this.txtPendiente = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPendientes
            // 
            this.lstPendientes.FormattingEnabled = true;
            this.lstPendientes.ItemHeight = 15;
            this.lstPendientes.Location = new System.Drawing.Point(12, 71);
            this.lstPendientes.Name = "lstPendientes";
            this.lstPendientes.Size = new System.Drawing.Size(318, 514);
            this.lstPendientes.TabIndex = 0;
            this.lstPendientes.SelectedIndexChanged += new System.EventHandler(this.lstPendientes_SelectedIndexChanged);
            // 
            // grdSolicitud
            // 
            this.grdSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSolicitud.Location = new System.Drawing.Point(336, 71);
            this.grdSolicitud.Name = "grdSolicitud";
            this.grdSolicitud.RowTemplate.Height = 25;
            this.grdSolicitud.Size = new System.Drawing.Size(962, 379);
            this.grdSolicitud.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Location = new System.Drawing.Point(935, 462);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(35, 41);
            this.txtTotal.TabIndex = 74;
            this.txtTotal.Tag = "";
            this.txtTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(825, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 71;
            this.label1.Tag = "txtTipoPago";
            this.label1.Text = "Total: ";
            // 
            // txtRechazar
            // 
            this.txtRechazar.BackColor = System.Drawing.Color.SeaGreen;
            this.txtRechazar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRechazar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRechazar.Image = ((System.Drawing.Image)(resources.GetObject("txtRechazar.Image")));
            this.txtRechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtRechazar.Location = new System.Drawing.Point(1083, 521);
            this.txtRechazar.Name = "txtRechazar";
            this.txtRechazar.Size = new System.Drawing.Size(215, 64);
            this.txtRechazar.TabIndex = 73;
            this.txtRechazar.Tag = "txtRechazar";
            this.txtRechazar.Text = "txtRechazar";
            this.txtRechazar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRechazar.UseVisualStyleBackColor = false;
            this.txtRechazar.Click += new System.EventHandler(this.txtRechazar_Click);
            // 
            // txtAprobar
            // 
            this.txtAprobar.BackColor = System.Drawing.Color.SeaGreen;
            this.txtAprobar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAprobar.Image = ((System.Drawing.Image)(resources.GetObject("txtAprobar.Image")));
            this.txtAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtAprobar.Location = new System.Drawing.Point(760, 523);
            this.txtAprobar.Name = "txtAprobar";
            this.txtAprobar.Size = new System.Drawing.Size(215, 64);
            this.txtAprobar.TabIndex = 72;
            this.txtAprobar.Tag = "txtAprobar";
            this.txtAprobar.Text = "txtAprobar";
            this.txtAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAprobar.UseVisualStyleBackColor = false;
            this.txtAprobar.Click += new System.EventHandler(this.txtAprobar_Click);
            // 
            // txtPendiente
            // 
            this.txtPendiente.AutoSize = true;
            this.txtPendiente.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPendiente.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPendiente.Location = new System.Drawing.Point(12, 27);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(200, 41);
            this.txtPendiente.TabIndex = 75;
            this.txtPendiente.Tag = "txtPendiente";
            this.txtPendiente.Text = "txtPendiente";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(336, 462);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(149, 41);
            this.lblEstado.TabIndex = 76;
            this.lblEstado.Tag = "lblEstado";
            this.lblEstado.Text = "lblEstado";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEstado.Location = new System.Drawing.Point(508, 462);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(153, 41);
            this.txtEstado.TabIndex = 77;
            this.txtEstado.Tag = "";
            this.txtEstado.Text = "txtEstado";
            // 
            // RevisionDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1311, 599);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPendiente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRechazar);
            this.Controls.Add(this.txtAprobar);
            this.Controls.Add(this.grdSolicitud);
            this.Controls.Add(this.lstPendientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RevisionDeCompra";
            this.Text = "Tutu CarSharing";
            this.Load += new System.EventHandler(this.RevisionDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstPendientes;
        private DataGridView grdSolicitud;
        private Label txtTotal;
        private Label label1;
        private Button txtRechazar;
        private Button txtAprobar;
        private Label txtPendiente;
        private Label lblEstado;
        private Label txtEstado;
    }
}