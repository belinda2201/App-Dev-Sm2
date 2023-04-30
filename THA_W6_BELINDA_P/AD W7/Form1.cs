namespace AD_W7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int input;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            input = Convert.ToInt32(txt_input.Text);
            if (input == 0)
            {
                MessageBox.Show("Must be greater than 0");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }
    }
}