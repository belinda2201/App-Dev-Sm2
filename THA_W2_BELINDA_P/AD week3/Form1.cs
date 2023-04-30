namespace AD_week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            int umur = Convert.ToInt32(txt_Umur.Text);

            if (umur <= 17)
            {
                string msgMinor = "Name : " + txt_Nama.Text + "\nEmail : " + txt_Email.Text + "\nPhone Number : " + txt_Notelp.Text + "\nYou are a minor.";
                MessageBox.Show(msgMinor);
            }
            else
            {
                string msgAdult = "Name : " + txt_Nama.Text + "\nEmail : " + txt_Email.Text + "\nPhone Number : " + txt_Notelp.Text + "\nYou are an adult.";
                MessageBox.Show(msgAdult);
            }     
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            txt_Nama.Clear();
            txt_Email.Clear();
            txt_Notelp.Clear();
            txt_Umur.Clear();
        }
    }
}