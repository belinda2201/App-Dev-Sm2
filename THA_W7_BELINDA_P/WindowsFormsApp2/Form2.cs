using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private List<string> judulMovie = new List<string>();
        private List<string> posterMovie = new List<string>();
        private List<string> sinopsisMovie = new List<string>();

        private Dictionary<string, List<string>> seat = new Dictionary<string, List<string>>();
        private int count;
        public Form2(int count, List<string> judulMovie, List<string> posterMovie, List<string> sinopsisMovie, Dictionary<string, List<string>> seat)
        {
            InitializeComponent();
            this.count = count;
            this.judulMovie= judulMovie;
            this.posterMovie= posterMovie;
            this.sinopsisMovie= sinopsisMovie;
            this.seat= seat;
        }
        

        public PictureBox picBox = new PictureBox(); 
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSalmon;

            PictureBox picturebox = new PictureBox();
            picturebox.Image = Image.FromFile(posterMovie[count]);
            picturebox.Size = new Size(300, 320);
            picturebox.Location = new Point(10, 20);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(picturebox);

            Label label_judul = new Label();
            label_judul.Text = judulMovie[count];
            label_judul.Font = new Font("Arial", 20, FontStyle.Bold);
            label_judul.TextAlign = ContentAlignment.MiddleLeft;
            label_judul.Size = new Size(400, 100);
            label_judul.BackColor = Color.Transparent;
            label_judul.Location = new Point(picturebox.Right + 10, picturebox.Top + 10);
            this.panel1.Controls.Add(label_judul);

            Label sinopsis = new Label();
            sinopsis.Text = sinopsisMovie[count];
            sinopsis.Font = new Font("Arial", 10, FontStyle.Regular);
            sinopsis.Size = new Size(440, 220);
            sinopsis.TextAlign = ContentAlignment.MiddleLeft;
            sinopsis.BackColor = Color.Transparent;
            sinopsis.SendToBack();
            sinopsis.Location = new Point(picturebox.Right + 10, picturebox.Top + 50);
            this.panel1.Controls.Add(sinopsis);

           

            Button jam1  = new Button();
            jam1.Text = "16.00";
            jam1.Location = new Point(310, 290);
            jam1.Size = new Size(100,50);
            jam1.Click += Jam1_Click;
            //jam1.BringToFront();
            this.panel1.Controls.Add(jam1);

            Button jam2 = new Button();
            jam2.Text = "19.00";
            jam2.Location = new Point(jam1.Right + 5, 290);
            jam2.Size = new Size(100, 50);
            jam2.Click += Jam2_Click;
            this.panel1.Controls.Add(jam2);

            Button jam3 = new Button();
            jam3.Text = "22.30";
            jam3.Location = new Point(jam2.Right + 5, 290);
            jam3.Size = new Size(100, 50);
            jam3.Click += Jam3_Click;
            this.panel1.Controls.Add(jam3);

            Button btn_return = new Button();
            btn_return.Text = "Return to movie selection";
            btn_return.Size = new Size(150, 50);
            btn_return.Location = new Point(jam3.Right + 5, 290);
            this.panel1.Controls.Add(btn_return);
            btn_return.BackColor = Color.White;
            //btn_return.BringToFront();
            btn_return.Click += Btn_return_Click;
        }

        private void Jam3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string jam = btn.Text;
            string jamke = Convert.ToString(btn.Tag);
            Form3 form3 = new Form3(count, judulMovie, posterMovie, sinopsisMovie, jam, jamke, seat);
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.ControlBox = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();
        }

        private void Jam2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string jam = btn.Text;
            string jamke = Convert.ToString(btn.Tag);
            Form3 form3 = new Form3(count, judulMovie, posterMovie, sinopsisMovie, jam, jamke, seat);
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.ControlBox = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();
        }

        private void Jam1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string jam = btn.Text;
            string jamke = Convert.ToString(btn.Tag);
            Form3 form3 = new Form3(count, judulMovie, posterMovie, sinopsisMovie, jam, jamke, seat);
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.ControlBox = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.seat = this.seat;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form);
            form.Show();
        }
    }
}
