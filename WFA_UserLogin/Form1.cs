using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string result;

        private void random_characters()
        {

            Random rnd = new Random();
            int num;
            result = "";

            for (int i = 0; i < 8; i++)
            {
                num = rnd.Next(10);
                result += num.ToString();

            }
            lblRastgeleSayi.Text = result;

        }
        private void lblRastgeleSayi_Click(object sender, EventArgs e)
        {
            random_characters();
        }

        private void txtGirisAlani_Click(object sender, EventArgs e)
        {

        }
        public int chance = 5;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtGirisAlani.Text == result)
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                txtGirisAlani.Clear();
                random_characters();
                txtGirisAlani.Select();
                PictureBox c = this.Controls.Find("star" + chance.ToString(), true).Single() as PictureBox;
                c.Visible = false;
                chance--;

                if (chance == 0)
                {
                    btnLogin.Enabled = false;
                    txtGirisAlani.Enabled = false;
                    lblRastgeleSayi.Text = "********";
                    MessageBox.Show("Giriş Sağlanamadı");

                    for (int i = 1; i < 6; i++)
                    {
                        PictureBox show = this.Controls.Find("star" + i.ToString(), true).Single() as PictureBox;
                        show.Visible = true;
                    }
                }
            }

        }

        private void star5_Click(object sender, EventArgs e)
        {

        }


        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
