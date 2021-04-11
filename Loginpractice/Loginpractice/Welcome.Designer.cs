
namespace Loginpractice
{
    partial class Welcome
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_welcome.Location = new System.Drawing.Point(312, 109);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(404, 68);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome  here";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(351, 240);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(300, 69);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(351, 374);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(300, 69);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create account";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel_2
            // 
            this.panel_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_2.BackColor = System.Drawing.Color.Blue;
            this.panel_2.Location = new System.Drawing.Point(162, 496);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(675, 1);
            this.panel_2.TabIndex = 72;
            // 
            // panel_4
            // 
            this.panel_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_4.BackColor = System.Drawing.Color.Blue;
            this.panel_4.Location = new System.Drawing.Point(161, 57);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(1, 440);
            this.panel_4.TabIndex = 71;
            // 
            // panel_3
            // 
            this.panel_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_3.BackColor = System.Drawing.Color.Blue;
            this.panel_3.Location = new System.Drawing.Point(162, 57);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(675, 1);
            this.panel_3.TabIndex = 70;
            // 
            // panel_1
            // 
            this.panel_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_1.BackColor = System.Drawing.Color.Blue;
            this.panel_1.Location = new System.Drawing.Point(836, 57);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(1, 440);
            this.panel_1.TabIndex = 72;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(996, 632);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_4);
            this.Controls.Add(this.panel_3);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Panel panel_1;
    }
}