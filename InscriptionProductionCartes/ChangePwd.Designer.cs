namespace InscriptionProductionCartes
{
    partial class ChangePwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldPwdLab = new System.Windows.Forms.Label();
            this.oldPwd = new System.Windows.Forms.TextBox();
            this.oldUserLab = new System.Windows.Forms.Label();
            this.oldUser = new System.Windows.Forms.TextBox();
            this.btnChgPwd = new System.Windows.Forms.Button();
            this.passwordLab = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.oldPwdLab);
            this.panel1.Controls.Add(this.oldPwd);
            this.panel1.Controls.Add(this.oldUserLab);
            this.panel1.Controls.Add(this.oldUser);
            this.panel1.Controls.Add(this.btnChgPwd);
            this.panel1.Controls.Add(this.passwordLab);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 353);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "New User name";
            // 
            // oldPwdLab
            // 
            this.oldPwdLab.AutoSize = true;
            this.oldPwdLab.Location = new System.Drawing.Point(111, 83);
            this.oldPwdLab.Name = "oldPwdLab";
            this.oldPwdLab.Size = new System.Drawing.Size(72, 13);
            this.oldPwdLab.TabIndex = 13;
            this.oldPwdLab.Text = "Old Password";
            // 
            // oldPwd
            // 
            this.oldPwd.Location = new System.Drawing.Point(63, 114);
            this.oldPwd.Name = "oldPwd";
            this.oldPwd.PasswordChar = '0';
            this.oldPwd.Size = new System.Drawing.Size(180, 20);
            this.oldPwd.TabIndex = 12;
            // 
            // oldUserLab
            // 
            this.oldUserLab.AutoSize = true;
            this.oldUserLab.Location = new System.Drawing.Point(111, 26);
            this.oldUserLab.Name = "oldUserLab";
            this.oldUserLab.Size = new System.Drawing.Size(77, 13);
            this.oldUserLab.TabIndex = 11;
            this.oldUserLab.Text = "Old User name";
            // 
            // oldUser
            // 
            this.oldUser.Location = new System.Drawing.Point(63, 51);
            this.oldUser.Name = "oldUser";
            this.oldUser.Size = new System.Drawing.Size(180, 20);
            this.oldUser.TabIndex = 10;
            // 
            // btnChgPwd
            // 
            this.btnChgPwd.Location = new System.Drawing.Point(125, 294);
            this.btnChgPwd.Name = "btnChgPwd";
            this.btnChgPwd.Size = new System.Drawing.Size(75, 23);
            this.btnChgPwd.TabIndex = 8;
            this.btnChgPwd.Text = "Save";
            this.btnChgPwd.UseVisualStyleBackColor = true;
            this.btnChgPwd.Click += new System.EventHandler(this.btnChgPwd_Click);
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(122, 230);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(53, 13);
            this.passwordLab.TabIndex = 7;
            this.passwordLab.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(66, 255);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '~';
            this.passwordBox.Size = new System.Drawing.Size(180, 20);
            this.passwordBox.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(66, 198);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(180, 20);
            this.userName.TabIndex = 4;
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 389);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePwd";
            this.Text = "ChangePwd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChgPwd;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label oldPwdLab;
        private System.Windows.Forms.TextBox oldPwd;
        private System.Windows.Forms.Label oldUserLab;
        private System.Windows.Forms.TextBox oldUser;
        private System.Windows.Forms.Label label1;
    }
}