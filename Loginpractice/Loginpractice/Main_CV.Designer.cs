
namespace Loginpractice
{
    partial class Main_CV
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_read.BackColor = System.Drawing.Color.LightCyan;
            this.btn_read.FlatAppearance.BorderSize = 0;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_read.Location = new System.Drawing.Point(1243, 352);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(141, 65);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "Open";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_write.BackColor = System.Drawing.Color.LightCyan;
            this.btn_write.FlatAppearance.BorderSize = 0;
            this.btn_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_write.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_write.Location = new System.Drawing.Point(1243, 221);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(141, 67);
            this.btn_write.TabIndex = 3;
            this.btn_write.Text = "Save";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // tb_data
            // 
            this.tb_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_data.Font = new System.Drawing.Font("Dutch801 Rm BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data.Location = new System.Drawing.Point(12, 12);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(728, 616);
            this.tb_data.TabIndex = 4;
            this.tb_data.Text = "Fill out your CV\r\n\r\n•Summary:\r\n\r\n•Education:\r\n\r\n•Skill Highlights:\r\n\r\n• Experienc" +
    "es:\r\n\r\n• Language:\r\n\r\n• Contact number, gmail:\r\n\r\n•Certifications:\r\n\r\n•Hobbies:";
            // 
            // tb_show
            // 
            this.tb_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_show.Font = new System.Drawing.Font("Dutch801 Rm BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_show.Location = new System.Drawing.Point(764, 12);
            this.tb_show.Multiline = true;
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(420, 616);
            this.tb_show.TabIndex = 8;
            // 
            // Main_CV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1445, 640);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Main_CV";
            this.Text = "Main_CV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_CV_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_show;
    }
}