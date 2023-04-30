using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_week_3
{
    public partial class SecondWindowForm : Form
    {
        public SecondWindowForm()
        {
            InitializeComponent();
            btn2_magic.Enabled = false;
        }

        private void SecondWindowForm_Load(object sender, EventArgs e)
        {
            string nama;
            string artist;
            nama = MainWindowForm.nama;
            artist = MainWindowForm.artist;

            label2_informasi.Text = "Hi, my name is " + nama + " and my favorite artist is " + artist + " !";
        }

        private void btn2_magic_Click(object sender, EventArgs e)
        {

                MainWindowForm formPertama = (MainWindowForm)this.Owner;

                if (rb_pink.Checked)
                {
                    formPertama.BackColor = Color.LightPink;
                }
                if (rb_vermillion.Checked)
                {
                    formPertama.BackColor = Color.OrangeRed;
                }
                if (rb_cyan.Checked)
                {
                    formPertama.BackColor = Color.LightCyan;
                }
                if (rb_pink.Checked)
                {
                    formPertama.BackColor = Color.LightPink;
                }
                if (rb_orange.Checked)
                {
                    formPertama.BackColor = Color.Tan;
                }
                if (rb_green.Checked)
                {
                    formPertama.BackColor = Color.DarkOliveGreen;
                }
            

                if (rb_grey.Checked)
                {
                    formPertama.ForeColor = Color.Gray;
                }
                if (rb_walnut.Checked)
                {
                    formPertama.ForeColor = Color.DarkKhaki;
                }
                if (rb_burgundyBrown.Checked)
                {
                    formPertama.ForeColor = Color.Brown;
                }
               
           

        }

        private void cb2_agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2_agreement.Checked == true & cb2_pickTrue.Checked == true)
            {
                btn2_magic.Enabled = true;
            }
            else
            {
                btn2_magic.Enabled = false;
            }
        }

        private void cb2_pickTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2_agreement.Checked == true & cb2_pickTrue.Checked == true)
            {
                btn2_magic.Enabled = true;
            }
            else
            {
                btn2_magic.Enabled = false;
            }
        }
    }
}
