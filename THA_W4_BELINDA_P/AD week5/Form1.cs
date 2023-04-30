using System.Diagnostics.Metrics;
using System.Windows.Forms.ComponentModel.Com2Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AD_week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dictionary isi team
        Dictionary<string, List<string>> teamCountry = new Dictionary<string, List<string>>();
        //dictionary isi player
        Dictionary<string, List<string>> playerTeam = new Dictionary<string, List<string>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //supaya ngga bisa di klik dulu
            comboBox_chooseTeam.Enabled = false;
            //tambahin country di comboBox chooseCountry
            comboBox_chooseCountry.Items.Add("England");
            comboBox_chooseCountry.Items.Add("Germany");

            //tambahin nama team di comboBox chooseTeam
            comboBox_chooseTeam.Items.Add("Manchester United");
            comboBox_chooseTeam.Items.Add("Chelsea");
            comboBox_chooseTeam.Items.Add("Bayem Munich");

            //isi team country England
            teamCountry.Add("England", new List<string> { "Manchester United" });
            teamCountry["England"].Add("Chelsea");

            //isi team country Germany
            teamCountry.Add("Germany", new List<string> { "Bayem Munich" });

            //isi player MU
            playerTeam.Add("England" + "Manchester United", new List<string>());
            playerTeam["England" + "Manchester United"].Add("(01)" + " David De Gea, " + "GK");
            playerTeam["England" + "Manchester United"].Add("(02)" + " Victor Lindelof, " + "DF");
            playerTeam["England" + "Manchester United"].Add("(04)" + " Phil Jones, " + "DF");
            playerTeam["England" + "Manchester United"].Add("(05)" + " Harry Maguire, " + "DF");
            playerTeam["England" + "Manchester United"].Add("(06)" + " Lisandro Martinez, " + "DF");
            playerTeam["England" + "Manchester United"].Add("(08)" + " Bruno Fernandez, " + "MF");
            playerTeam["England" + "Manchester United"].Add("(09)" + " Anthony Martial, " + "FW");
            playerTeam["England" + "Manchester United"].Add("(10)" + " Marcus Rashford, " + "FW");
            playerTeam["England" + "Manchester United"].Add("(12)" + " Tyrell Malacia, " + "DF");
            playerTeam["England" + "Manchester United"].Add("(14)" + " Christian Eniksen, " + "MF");
            playerTeam["England" + "Manchester United"].Add("(18)" + " Casemiro, " + "MF");

            //isi player Chelsea
            playerTeam.Add("England" + "Chelsea", new List<string>());
            playerTeam["England" + "Chelsea"].Add("(01)" + " Keva Arrizabalaga, " + "GK");
            playerTeam["England" + "Chelsea"].Add("(04)" + " Benoit Badiashile, " + "DF");
            playerTeam["England" + "Chelsea"].Add("(05)" + " Endo Fernadez, " + "MF");
            playerTeam["England" + "Chelsea"].Add("(07)" + " N'Golo Kante, " + "MF");
            playerTeam["England" + "Chelsea"].Add("(08)" + " Mateo Kovacic, " + "MF");
            playerTeam["England" + "Chelsea"].Add("(09)" + " Pierre-Emerick Aubameyang, " + "FW");
            playerTeam["England" + "Chelsea"].Add("(10)" + " Christian Pulisic, " + "MF");
            playerTeam["England" + "Chelsea"].Add("(11)" + " Joao Felix, " + "FW");
            playerTeam["England" + "Chelsea"].Add("(12)" + " Ruben Loftus-Cheek, " + "MF");
            playerTeam["England" + "Chelsea"].Add("(17)" + " Raheem Sterling, " + "MF");

            //isi player Bayem Munich
            playerTeam.Add("Germany" + "Bayem Munich", new List<string>());
            playerTeam["Germany" + "Bayem Munich"].Add("(01)" + " Manuel Neuer, " + "GK");
            playerTeam["Germany" + "Bayem Munich"].Add("(02)" + " Dayot Upamecano, " + "DF");
            playerTeam["Germany" + "Bayem Munich"].Add("(04)" + " Matthijs de Ligt, " + "DF");
            playerTeam["Germany" + "Bayem Munich"].Add("(05)" + " Benjamin Pavard, " + "DF");
            playerTeam["Germany" + "Bayem Munich"].Add("(06)" + " Joshua Kimmich, " + "MF");
            playerTeam["Germany" + "Bayem Munich"].Add("(07)" + " Serge Gnarby, " + "FW");
            playerTeam["Germany" + "Bayem Munich"].Add("(08)" + " Leon Goretzka, " + "MF");
            playerTeam["Germany" + "Bayem Munich"].Add("(10)" + " Leroy Sane, " + "FW");
            playerTeam["Germany" + "Bayem Munich"].Add("(14)" + " Paul Wanner, " + "MF");
            playerTeam["Germany" + "Bayem Munich"].Add("(21)" + " Lucas Hernandez, " + "DF");
            playerTeam["Germany" + "Bayem Munich"].Add("(25)" + " Thomas Muller, " + "FW");
        }

        
        private void btn_addTeam_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_teamCountry.Text) && !string.IsNullOrEmpty(txt_teamCity.Text) & !string.IsNullOrEmpty(txt_teamName.Text))
            {
                Team team1 = new Team();
                team1.teamName = txt_teamName.Text;
                team1.teamCity = txt_teamCity.Text;
                team1.teamCountry = txt_teamCountry.Text;

                if (playerTeam.ContainsKey(team1.teamName + team1.teamCountry))
                {
                    MessageBox.Show("Sudah ada tim dengan nama yang sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!playerTeam.ContainsKey(team1.teamName + team1.teamCountry))
                {
                    if (teamCountry.ContainsKey(team1.teamCountry))
                    {
                        teamCountry[team1.teamCountry].Add(team1.teamName);
                    }
                    else
                    {
                        teamCountry.Add(team1.teamCountry, new List<string> {team1.teamName});
                        comboBox_chooseCountry.Items.Add(team1.teamCountry);
                    }
                    playerTeam.Add(team1.teamCountry + team1.teamName, new List<string>());
                    comboBox_chooseTeam.Items.Add(team1.teamName);
                }            
                txt_teamCountry.Clear();
                txt_teamName.Clear();
                txt_teamCity.Clear();
                txt_teamName.Focus();
            }
            else
            {
                MessageBox.Show("Field belum diisi", "Isi Field yang Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_teamName.Focus();
            }
        }

        private void btn_addPlayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_playerName.Text) && !string.IsNullOrEmpty(txt_playerNumber.Text))
            {
                string namaPlayer = txt_playerName.Text;
                bool cek = false;

                foreach (string cekPlayer in listBox_show.Items)
                {
                    if (cekPlayer.Contains(namaPlayer))
                    {
                        cek = true;
                        break;
                    }
                }
                if (cek == false)
                {
                    Player player1 = new Player();
                    player1.playerName = txt_playerName.Text;
                    player1.playerNum = txt_playerNumber.Text;
                    player1.playerPos = comboBox_playerPosition.SelectedItem.ToString();
                    string namaTim = comboBox_chooseTeam.SelectedItem.ToString();
                    string namaNegara = comboBox_chooseCountry.SelectedItem.ToString();
                    playerTeam[namaNegara + namaTim].Add("(" + player1.playerNum + ")" + "  " + player1.playerName + "  " + ", " + player1.playerPos);
                    listBox_show.Items.Clear();
                    comboBox_chooseTeam_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Sudah ada player dengan nama yang sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txt_playerNumber.Clear();
                txt_playerName.Clear();
                txt_playerName.Focus();
            }
            else
            {
                MessageBox.Show("Field belum diisi", "Isi Field yang Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            string pilihNegara = comboBox_chooseCountry.SelectedItem.ToString();
            string pilihTim = comboBox_chooseTeam.SelectedItem.ToString();

            if (pilihNegara != null && pilihTim != null)
            {
                if (playerTeam.ContainsKey(pilihNegara + pilihTim))
                {
                    string pilihPlayer = listBox_show.SelectedItem.ToString();
                    if (pilihPlayer != null)
                    {
                        if (playerTeam[pilihNegara + pilihTim].Count >= 11)
                        {
                            playerTeam[pilihNegara + pilihTim].Remove(pilihPlayer);
                            listBox_show.DataSource = playerTeam[pilihNegara + pilihTim];
                        }
                        else
                        {
                            MessageBox.Show("Jumlah player tidak boleh kurang dari 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Team tidak ada di dalam konteks");
                }
            }
        }
            

            private void comboBox_chooseCountry_SelectionChangeCommitted(object sender, EventArgs e)
            {
            Team team1 = new Team();
            foreach (Player pemain in team1.Players)
            {
                listBox_show.Items.Add(pemain.playerNum + " " + pemain.playerName + " " + pemain.playerPos);
            }
                    }

        private void comboBox_chooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_chooseCountry.SelectedItem != null)
            {
                comboBox_chooseTeam.Enabled = true;
                string teamSelect = comboBox_chooseTeam.SelectedItem.ToString();

                if (teamSelect != null)
                {
                    listBox_show.Items.Clear();
                    listBox_show.DataSource = null;
                }
                else
                {
                    listBox_show.DataSource = null;
                }

                List<string> players = playerTeam.ContainsKey(comboBox_chooseCountry.SelectedItem.ToString() + teamSelect) ? playerTeam[comboBox_chooseCountry.SelectedItem.ToString() + teamSelect] : new List<string>();
                foreach (string player in players)
                {
                    listBox_show.Items.Add(player);
                }
            }
            
        }

        private void comboBox_chooseCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_chooseTeam.Items.Clear();
            string pilihCountry = comboBox_chooseCountry.SelectedItem.ToString();
            List<string> teams = teamCountry[pilihCountry];

            foreach(string a in teams)
            {
                comboBox_chooseTeam.Items.Add(a);
            }
            comboBox_chooseTeam.SelectedIndex = 0;
        }
    }
}