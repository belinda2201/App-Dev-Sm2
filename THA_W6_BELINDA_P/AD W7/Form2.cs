using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_W7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //isi txt
        string[] listWords;
        //string tebak dari user
        string tebak = "";
        //string jawaban dari txt
        string jawaban;
        //array button
        Button[,] button;
        int baris = 0;
        int kolom = 0;
        int counterCek = 0;
        bool win = false;


        private void Form2_Load(object sender, EventArgs e)
        {
            //read txt file
            string words = File.ReadAllText("Wordle Word List.txt");
            listWords = words.Split(',');

            //randomize buat jawaban
            Random random = new Random();
            int randomize = random.Next(0, listWords.Length);
            jawaban = listWords[randomize];

            //bikin buttons
            button = new Button[Form1.input, 5];
            int a = 200;
            int b = 200;
            for (int i = 0; i < Form1.input; i++) //ke bawah
            {
                for (int j = 0; j < 5; j++) //ke kanan
                {
                    button[i, j] = new Button();
                    button[i, j].Size = new Size(150, 150);
                    button[i, j].Location = new Point(150 * j + 50, 150 * i + 50);
                    button[i, j].Tag = i.ToString() + "," + j.ToString();
                    button[i, j].Click += buttonArray_Click;
                    this.Controls.Add(button[i, j]);
                    b += 150;
                }
                a += 150;
                b = 200;
            }

            //cek isi list nya udh masuk ato belom
            MessageBox.Show(jawaban.ToString()); //file udah kebaca
        }

        private void buttonArray_Click(object? sender, EventArgs e)
        {
            //checking button
            //MessageBox.Show((sender as Button).Text.ToString());
        }

        private void button_click(object sender, EventArgs e)
        {
            if (win == false)
            {
                if (baris != 5)
                {
                    Button tmp = sender as Button;
                    tebak = string.Concat(tebak, tmp.Text);
                    button[kolom, baris].Text = tmp.Text;
                    baris++;
                }
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (win == false)
            {
                if (button[kolom, 0].Text != "")
                {
                    if (!listWords.Contains<string>(tebak.ToLower()))
                    {
                        string msg = tebak.ToUpper() + " is not a word";
                        MessageBox.Show(msg);
                        int counter = baris;
                        for (int i = 0; i < counter; i++)
                        {
                            baris--;
                            tebak = tebak.Substring(0, baris);
                            button[kolom, baris].Text = "";
                        }
                        counter = 0;
                    }
                    else
                    {
                        cekWin();
                        kolom++;
                        baris = 0;
                        tebak = "";
                    }
                }
            }
            else
            {
                win = true;
            }
        }

            private void btn_del_Click(object sender, EventArgs e)
            {
            if (win == false)
            {
                if (baris != 0)
                {
                    baris--;
                    tebak = tebak.Substring(0, baris);
                    button[kolom, baris].Text = "";
                }
            }
        }

         public void cekWin()
         {
            if (tebak != "")
            {
                counterCek = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (jawaban[i] == tebak.ToLower()[i])
                    {
                        button[kolom, i].BackColor = Color.LightGreen;
                        counterCek++;
                    }
                    else if (jawaban.Contains<char>(tebak.ToLower()[i]))
                    {
                        button[kolom, i].BackColor = Color.LightYellow;
                    }
                    else
                    {
                        button[kolom, i].BackColor = Color.LightGray;
                    }
                }

                if (counterCek == 5)
                {
                        string msg = "Congratulations! The correct word is " + jawaban;
                        MessageBox.Show(msg);
                        win = true;
                }
                else if (kolom == Form1.input - 1)
                {
                    win = true;
                    string msg = "You lose! The correct word is " + jawaban + ".\nBetter luck next time!";
                        MessageBox.Show(msg);
                }
            }
        }
    }
    
}
