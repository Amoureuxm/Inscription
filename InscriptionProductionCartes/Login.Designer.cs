namespace InscriptionProductionCartes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReconnexion = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordLab = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userLab = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReconnexion);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.passwordLab);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.userLab);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Location = new System.Drawing.Point(137, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 278);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReconnexion
            // 
            this.btnReconnexion.Location = new System.Drawing.Point(226, 12);
            this.btnReconnexion.Name = "btnReconnexion";
            this.btnReconnexion.Size = new System.Drawing.Size(75, 23);
            this.btnReconnexion.TabIndex = 9;
            this.btnReconnexion.Text = "Connexion";
            this.btnReconnexion.UseVisualStyleBackColor = true;
            this.btnReconnexion.Click += new System.EventHandler(this.btnReconnexion_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(121, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(131, 156);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(53, 13);
            this.passwordLab.TabIndex = 7;
            this.passwordLab.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(62, 172);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '0';
            this.passwordBox.Size = new System.Drawing.Size(180, 20);
            this.passwordBox.TabIndex = 6;
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(126, 88);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(58, 13);
            this.userLab.TabIndex = 5;
            this.userLab.Text = "User name";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(62, 122);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(180, 20);
            this.userName.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 392);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button btnReconnexion;
        private System.Windows.Forms.Button btnLogin;
    }
}