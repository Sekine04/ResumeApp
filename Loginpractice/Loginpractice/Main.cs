using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginpractice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string file = "accountdata.txt";
            string username = File.ReadLines(file).First();
            string password = File.ReadLines(file).Last();

            username = username.Split(':')[1];
            password = password.Split(':')[1];

            if (username == tb_username.Text && password== tb_password.Text)

            {
                Main_CV m = new Main_CV();
                m.Show();
                this.Hide();

            }

            else
            {
                lbl_status.Visible = true;
            }
        }

        private void linklbl_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }
    }
}
