namespace CA_week_3
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        public static string nama = "";
        public static string artist = "";

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
        }

        private void btn_toForm2_Click(object sender, EventArgs e)
        {
            SecondWindowForm form2 = new SecondWindowForm();
            form2.ShowDialog(this);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            nama = txt_nama.Text;
            artist = txt_artist.Text;
        }

        private void cb_confirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_confirm.Checked == true)
            {
                btn_submit.Enabled = true;
                
            }
            else
            {
                btn_submit.Enabled = false;
                MessageBox.Show("Centang persetujuan dulu");
            }
        }
    }
}