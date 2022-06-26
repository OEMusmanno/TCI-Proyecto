namespace Campo_TPFinal_UI
{
    partial class Login
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonLenguaje = new System.Windows.Forms.Button();
            this.LenguajeLabel = new System.Windows.Forms.Label();
            this.botonLenguaje1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(69, 265);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(100, 50);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Tag = "btnLogIn";
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(69, 144);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(69, 225);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 23);
            this.txtPass.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(72, 116);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(81, 25);
            this.userLabel.TabIndex = 3;
            this.userLabel.Tag = "userLabel";
            this.userLabel.Text = "Usuario";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(72, 197);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Tag = "passwordLabel";
            this.passwordLabel.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 65);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tutú ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carsharing";
            // 
            // botonLenguaje
            // 
            this.botonLenguaje.ForeColor = System.Drawing.Color.Black;
            this.botonLenguaje.Location = new System.Drawing.Point(12, 362);
            this.botonLenguaje.Name = "botonLenguaje";
            this.botonLenguaje.Size = new System.Drawing.Size(94, 36);
            this.botonLenguaje.TabIndex = 7;
            this.botonLenguaje.Tag = "";
            this.botonLenguaje.Text = "Español";
            this.botonLenguaje.UseVisualStyleBackColor = true;
            this.botonLenguaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // LenguajeLabel
            // 
            this.LenguajeLabel.AutoSize = true;
            this.LenguajeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LenguajeLabel.Location = new System.Drawing.Point(69, 334);
            this.LenguajeLabel.Name = "LenguajeLabel";
            this.LenguajeLabel.Size = new System.Drawing.Size(98, 25);
            this.LenguajeLabel.TabIndex = 8;
            this.LenguajeLabel.Tag = "LenguajeLabel";
            this.LenguajeLabel.Text = "Lenguaje:";
            // 
            // botonLenguaje1
            // 
            this.botonLenguaje1.ForeColor = System.Drawing.Color.Black;
            this.botonLenguaje1.Location = new System.Drawing.Point(127, 362);
            this.botonLenguaje1.Name = "botonLenguaje1";
            this.botonLenguaje1.Size = new System.Drawing.Size(100, 36);
            this.botonLenguaje1.TabIndex = 9;
            this.botonLenguaje1.Tag = "";
            this.botonLenguaje1.Text = "English";
            this.botonLenguaje1.UseVisualStyleBackColor = true;
            this.botonLenguaje1.Click += new System.EventHandler(this.botonLenguaje1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(248, 399);
            this.Controls.Add(this.botonLenguaje1);
            this.Controls.Add(this.LenguajeLabel);
            this.Controls.Add(this.botonLenguaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogIn);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogIn;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label userLabel;
        private Label passwordLabel;
        private Label label3;
        private Label label4;
        private Button botonLenguaje;
        private Label LenguajeLabel;
        private Button botonLenguaje1;
    }
}