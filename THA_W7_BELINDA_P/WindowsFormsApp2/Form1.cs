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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string> judulMovie = new List<string>();
        public static List<string> posterMovie = new List<string>();
        public static List<string> sinopsisMovie = new List<string>();

        public Dictionary<string, List<string>> seat = new Dictionary<string, List<string>>();
        

        //public string[] simpan;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSalmon;
            
            //panel_tampil.AutoScroll = true;
            //HScrollBar hScrollBar1 = new HScrollBar();
            //panel_tampil.Controls.Add(hScrollBar1);

            string file = @".\Poster Movie\title poster sinopsis.txt";

            using (StreamReader sr = new StreamReader(file))
            {
                string a;
                while ((a = sr.ReadLine()) != null)
                {
                    string[] simpan = a.Split(',');
                    if (simpan.Length == 3)
                    {
                        judulMovie.Add(simpan[0]);
                        posterMovie.Add(simpan[1]);
                        sinopsisMovie.Add(simpan[2]);
                    }
                }
            }

            Label label_intro = new Label();
            label_intro.Text = "Welcome! What do you want to watch today?";
            label_intro.Font = new Font("Arial", 10, FontStyle.Bold);
            label_intro.Location = new Point(10, 10);
            label_intro.AutoSize = true;
            this.panel_tampil.Controls.Add(label_intro);

            //if (simpan.Length == 3)
            //{
            //    judulMovie.Add(simpan[0]);
            //    posterMovie.Add(simpan[1]);
            //    sinopsisMovie.Add(simpan[2]);
            //}

            int counter = 0;

            for (int i = 0; i < posterMovie.Count; i++)
            {
                PictureBox picturebox = new PictureBox();
                picturebox.Image = Image.FromFile(posterMovie[i]);
                picturebox.Size = new Size(200, 220);
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                picturebox.Tag = i;
                picturebox.Location = new Point((counter % 4) * 260 + 12, (counter / 4) * 280 + 40);
                picturebox.Click += Picturebox_Click;
                this.panel_tampil.Controls.Add(picturebox);
                counter++;

                Label label = new Label();
                label.Text = judulMovie[i];
                label.Font = new Font("Arial", 9, FontStyle.Italic);
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(picturebox.Left + 15, picturebox.Bottom + 5);
                this.panel_tampil.Controls.Add(label);
            }
        }

        private void Picturebox_Click(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            string judulMovie_ = picturebox.Tag.ToString();
            int count = (int)picturebox.Tag;

            Form2 form2 = new Form2(count, judulMovie, posterMovie, sinopsisMovie, seat);
            form2.picBox = picturebox;
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            form2.ControlBox = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            this.panel_tampil.Controls.Clear();
            this.panel_tampil.Controls.Add(form2);
            form2.Show();
        }
    }
}
