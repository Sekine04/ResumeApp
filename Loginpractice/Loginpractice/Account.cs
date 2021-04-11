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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(tb_password.Text==tb_confirmpassword.Text)
            { 
            if (checkbox_agree.Checked)
            {
                StreamWriter S = new StreamWriter(Application.StartupPath + "accountdata.txt");
                
                S.WriteLine(lbl_username.Text + tb_username.Text);
               
                S.WriteLine(lbl_firstname.Text + tb_firstname.Text);
                S.WriteLine(lbl_lastname.Text + tb_lastname.Text);
                S.WriteLine(lbl_dateofbirth.Text + tb_day.Text + "." + tb_month.Text + "." + tb_year.Text);
                S.WriteLine(lbl_phone.Text +  tb_phone.Text);
                S.WriteLine(lbl_email.Text + tb_email.Text);

                if (rb_female.Checked)
                {
                   S.WriteLine( lbl_gender.Text+ "Female");
                }
                else { S.WriteLine(lbl_gender.Text + "Male"); }
                S.WriteLine(lbl_password.Text + tb_password.Text);
                

                S.Close();



                MessageBox.Show("Your account has already been created!");
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Visible = true;

            }}
            else
            {
                lbl_passworderror.Visible = true;
            }
        }

        
    }
}
