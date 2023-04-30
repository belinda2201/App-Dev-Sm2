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
    public partial class Form3 : Form
    {
        private List<string> judulMovie = new List<string>();
        private List<string> posterMovie = new List<string>();
        private List<string> sinopsisMovie = new List<string>();
        List<Button> listbutton = new List<Button>();
        List<Button> listredbutton = new List<Button>();
        List<Button> listselectedbutton = new List<Button>();
        private Dictionary<string, List<string>> seat = new Dictionary<string, List<string>>();
        private int count;
        string jam;
        string jamke;
        public Form3(int count, List<string> judulMovie, List<string> posterMovie, List<string> sinopsisMovie, string jam, string jamke, Dictionary<string, List<string>> seat)
        {
            InitializeComponent();
            this.count = count;
            this.judulMovie = judulMovie;
            this.posterMovie = posterMovie;
            this.sinopsisMovie = sinopsisMovie;
            this.seat = seat;
            this.jam = jam;
            this.jamke = jamke;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSalmon;

            string movieDipilih = $"{Convert.ToString(count)} {jamke}";

            Label label_judul = new Label();
            label_judul.Location = new Point(175, 60);
            label_judul.Text = $" {judulMovie[count]}  on {jam} PM";
            label_judul.Font = new Font("Arial", 10, FontStyle.Bold);
            label_judul.AutoSize = true;
            label_judul.TextAlign = ContentAlignment.MiddleLeft;
            this.panel1.Controls.Add(label_judul);

            Label screen = new Label();
            screen.Location = new Point(310, 630);
            screen.Text = "SCREEN IS OVER HERE";
            screen.AutoSize = true;
            screen.Font = new Font ("Arial", 15, FontStyle.Bold);
            this.panel1.Controls.Add(screen);

            Button btn_pilih = new Button();
            btn_pilih.Text = "Reserve the seat";
            btn_pilih.Size = new Size(100,50);
            btn_pilih.Location = new Point(screen.Right + 150, 560);
            this.panel1.Controls.Add(btn_pilih);
            btn_pilih.BackColor = Color.White;
            btn_pilih.Click += Btn_pilih_Click;

            Button btn_reset = new Button();
            btn_reset.Text = "Reset";
            btn_reset.Size = new Size(100,50);
            btn_reset.Location = new Point(screen.Right + 150, btn_pilih.Bottom + 5);
            btn_reset.BackColor = Color.White;
            btn_reset.Click += Btn_reset_Click;
            this.panel1.Controls.Add(btn_reset);

            Button btn_return= new Button();
            btn_return.Text = "Return to previous page";
            btn_return.Size = new Size(120,50);
            btn_return.Location = new Point(50, btn_reset.Top);
            btn_return.BackColor = Color.White;
            this.panel1.Controls.Add(btn_return);
            btn_return.Click += Btn_return_Click;

            char collumn = 'J';
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Text = $"{collumn} {j + 1}";
                    button.Location = new Point(50 * j + 180, 50 * i + 100);
                    this.panel1.Controls.Add(button);
                    this.listbutton.Add(button);
                    button.Click += Button_Click; ;
                }
                collumn--;
            }


            if (seat.ContainsKey(movieDipilih))
            {
                List<string> bookedSeat = seat[movieDipilih];
                foreach (string seat in bookedSeat)
                {
                    int count = listbutton.FindIndex(button => button.Text == seat);
                    listbutton[count].BackColor = Color.OrangeRed;
                }
            }
            else
            {
                List<string> bookedSeat = new List<string>();
                Random rnd = new Random();
                int num = rnd.Next(0, 71);
                for (int i = 0; i < num; i++)
                {
                    int randIndex = rnd.Next(0, 100);
                    listbutton[randIndex].BackColor = Color.OrangeRed;
                    bookedSeat.Add(listbutton[randIndex].Text);
                }
                seat[movieDipilih] = bookedSeat;
            }

            foreach (Button button in listbutton)
            {
                if (button.BackColor != Color.OrangeRed)
                {
                    button.BackColor = Color.LightGreen;
                }
            }
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(count, judulMovie, posterMovie, sinopsisMovie, seat);
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            form2.ControlBox = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form2);
            form2.Show();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            List<string> bookedSeat = new List<string>();
            DialogResult result = MessageBox.Show("Are you sure to reset?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (Button button in listbutton)
                {
                    button.BackColor = Color.MediumSpringGreen;
                    listredbutton.Clear();
                    listselectedbutton.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seat not cleared");
            }
            foreach (Button button in listbutton)
            {
                if (button.BackColor == Color.OrangeRed)
                {
                    bookedSeat.Add(button.Text);
                }
            }
            string filmdanjam = $"{Convert.ToString(count)} {jamke}";
            seat[filmdanjam] = bookedSeat;
        }

        private void Btn_pilih_Click(object sender, EventArgs e)
        {
            List<string> bookedSeat = new List<string>();
            string selectedSeats = string.Join(", ", listselectedbutton.Select(button => button.Text));
            if (listselectedbutton.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to book the seats?", "Booking Seat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("The seat has been booked", "Seat Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Button button in listselectedbutton)
                    {
                        button.BackColor = Color.OrangeRed;
                    }
                    foreach (Button button in listbutton)
                    {
                        if (button.BackColor == Color.OrangeRed)
                        {
                            bookedSeat.Add(button.Text);
                        }
                    }

                    string filmdanjam = $"{Convert.ToString(count)} {jamke}";
                    seat[filmdanjam] = bookedSeat;
                    listselectedbutton.Clear();
                    selectedSeats = "";
                }
                else
                {
                    listselectedbutton.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please book one or more seat.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button seatPilih = sender as Button;

            if (seatPilih.BackColor == Color.OrangeRed)
            {
                MessageBox.Show("Please pick other available seat.", "Seat Already Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (seatPilih.BackColor == Color.LightGreen)
            {
                seatPilih.BackColor = Color.Gold;
                listselectedbutton.Add(seatPilih);
                string selectedSeats = string.Join(", ", listselectedbutton.Select(button => button.Text));
                //label_select.Text = $"Selected Seat: {selectedSeats}";
            }
            else if (seatPilih.BackColor == Color.Gold)
            {
                seatPilih.BackColor = Color.LightGreen;
                listselectedbutton.Remove(seatPilih);
                string selectedSeats = string.Join(", ", listselectedbutton.Select(button => button.Text));
                //label_select.Text = $"Selected Seat: {selectedSeats}";
            }
        }
    }
}
