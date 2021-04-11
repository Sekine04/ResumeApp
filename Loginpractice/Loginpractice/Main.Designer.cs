
namespace Loginpractice
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.picturebox_username = new System.Windows.Forms.PictureBox();
            this.picturebox_password = new System.Windows.Forms.PictureBox();
            this.linklbl_account = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_password)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_username.ForeColor = System.Drawing.Color.Blue;
            this.tb_username.Location = new System.Drawing.Point(336, 115);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(287, 26);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.Blue;
            this.tb_password.Location = new System.Drawing.Point(336, 191);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(287, 26);
            this.tb_password.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_username.Location = new System.Drawing.Point(207, 113);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(112, 26);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username :";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_password.Location = new System.Drawing.Point(207, 189);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(109, 26);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("BankGothic Md BT", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_login.Location = new System.Drawing.Point(325, 33);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(182, 41);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "LOG IN";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_status.Location = new System.Drawing.Point(231, 330);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(348, 23);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Username or password is incorrect!";
            this.lbl_status.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("BankGothic Md BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(196, 273);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(416, 41);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_1
            // 
            this.panel_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_1.BackColor = System.Drawing.Color.Blue;
            this.panel_1.Location = new System.Drawing.Point(173, 147);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(456, 1);
            this.panel_1.TabIndex = 9;
            // 
            // panel_2
            // 
            this.panel_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_2.BackColor = System.Drawing.Color.Blue;
            this.panel_2.Location = new System.Drawing.Point(173, 221);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(456, 1);
            this.panel_2.TabIndex = 10;
            // 
            // picturebox_username
            // 
            this.picturebox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturebox_username.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_username.Image")));
            this.picturebox_username.Location = new System.Drawing.Point(173, 105);
            this.picturebox_username.Name = "picturebox_username";
            this.picturebox_username.Size = new System.Drawing.Size(28, 34);
            this.picturebox_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_username.TabIndex = 11;
            this.picturebox_username.TabStop = false;
            // 
            // picturebox_password
            // 
            this.picturebox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturebox_password.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_password.Image")));
            this.picturebox_password.Location = new System.Drawing.Point(173, 185);
            this.picturebox_password.Name = "picturebox_password";
            this.picturebox_password.Size = new System.Drawing.Size(28, 30);
            this.picturebox_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_password.TabIndex = 12;
            this.picturebox_password.TabStop = false;
            // 
            // linklbl_account
            // 
            this.linklbl_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklbl_account.AutoSize = true;
            this.linklbl_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbl_account.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_account.Location = new System.Drawing.Point(325, 369);
            this.linklbl_account.Name = "linklbl_account";
            this.linklbl_account.Size = new System.Drawing.Size(164, 19);
            this.linklbl_account.TabIndex = 13;
            this.linklbl_account.TabStop = true;
            this.linklbl_account.Text = "No account? Creat one!";
            this.linklbl_account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_account_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linklbl_account);
            this.Controls.Add(this.picturebox_password);
            this.Controls.Add(this.picturebox_username);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.PictureBox picturebox_username;
        private System.Windows.Forms.PictureBox picturebox_password;
        private System.Windows.Forms.LinkLabel linklbl_account;
    }
}

