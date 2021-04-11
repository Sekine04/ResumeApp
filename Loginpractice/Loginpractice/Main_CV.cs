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
    public partial class Main_CV : Form
    {
        public Main_CV()
        {
            InitializeComponent();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            string data =tb_data.Text;
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Filter = "Only text files |*.txt";
            sfd.FileName = "CV.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(data);
                sw.Close();
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                tb_show.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void Main_CV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
