using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_ad.Text=="")
            {
                MessageBox.Show("lütfen kullanıcı adınızı giriniz ","bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ad.Focus();
            }
            else if(txt_sifre.Text=="")
            {
                MessageBox.Show("lütfen kullanıcı şifrenizi giriniz ", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sifre.Focus();
            }
            else if(txt_ad.Text=="admin"||txt_sifre.Text=="123")
            {
                this.Close();

            }
            else
            {
             
                MessageBox.Show("kullanıcı adını/kullanıcı şifre ' nizi yanlış girdiniz lütfen tekrar deneyiniz", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ad.Clear();
                txt_sifre.Clear();
                txt_ad.Focus();

             
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_sifre.PasswordChar = '*';
            }
        }
    }
}
