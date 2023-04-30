using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AD_Week_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btn_search.Enabled = false;
        }

        string connectionString = "server=localhost;uid=root;pwd=0318053478Bel.;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataReader sqlDataReader;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtPlayerBio = new DataTable();
        DataTable dtPlayerMatchData = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {     
            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "select team_name as `Team Name` from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cb_team.DataSource = dtTeam;
            cb_team.DisplayMember = "Team Name";
            cb_team.ValueMember = "Team Name";
            
            if (cb_player.Text == "" && cb_team.Text == "")
            {
                btn_search.Enabled=false;
            }
            cb_player.Text = "";
            cb_team.Text = "";


        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPlayer = new DataTable();
            sqlQuery = "select p.player_id as `ID Player`, p.player_name as `Player Name` from player p, team t where t.team_id = p.team_id and t.team_name = '" + cb_team.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            cb_player.DataSource = dtPlayer;
            cb_player.ValueMember = "ID PLayer";
            cb_player.DisplayMember = "Player Name";
            btn_search.Enabled = false;

            cb_player.Text = "";
            btn_search.Enabled = false;

        }

        private void cb_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlQuery = "select p.player_name, t.team_name, if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'position', n.nation as 'nationality', p.team_number from player p, team t, nationality n where t.team_id = p.team_id and t.team_name = '" + cb_team.Text + "' and p.player_name = '" + cb_player.Text + "' and p.nationality_id = n.nationality_id;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPlayerBio);

            //sqlQuery = "select d.type, count(*) as count from dmatch d where d.player_id = '" + cb_player.SelectedValue.ToString() + "' group by d.type;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPlayerMatchData);

            btn_search.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtPlayerBio= new DataTable();
            sqlQuery = "select p.player_name, t.team_name, if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'position', n.nation as 'nationality', p.team_number from player p, team t, nationality n where t.team_id = p.team_id and t.team_name = '" + cb_team.Text +"' and p.player_name = '" + cb_player.Text + "' and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerBio);

            dtPlayerMatchData = new DataTable();
            sqlQuery = "select d.type, count(*) as count from dmatch d where d.player_id = '" + cb_player.SelectedValue + "' group by d.type;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerMatchData);


            string playerName = dtPlayerBio.Rows[0]["player_name"].ToString();
            string teamName = dtPlayerBio.Rows[0]["team_name"].ToString();
            string position = dtPlayerBio.Rows[0]["position"].ToString();
            string nationality = dtPlayerBio.Rows[0]["nationality"].ToString();
            string sqNumber = dtPlayerBio.Rows[0]["team_number"].ToString();

            int yellowCard = 0;
            int redCard = 0;
            int goal = 0;
            int penaltymiss = 0;

            foreach (DataRow row in dtPlayerMatchData.Rows)
            {
                string detail = row["type"].ToString();
                int counter = Convert.ToInt32(row["count"]);
                if (detail == "CY")
                {
                    yellowCard = counter;
                }
                else if (detail == "CR")
                {
                    redCard = counter;
                }
                else if (detail == "GO")
                {
                    goal = counter;
                }
                else if (detail == "PM")
                {
                    penaltymiss = counter;
                }
            }

            label_namaPlayer.Text = playerName;
            label_team.Text = teamName;
            label_pos.Text = position;
            label_nationality.Text = nationality;
            label_sqNumber.Text = sqNumber;
            label_yellow.Text = yellowCard.ToString();
            label_red.Text = redCard.ToString();
            label_goal.Text = goal.ToString();
            label_penaltyMiss.Text = penaltymiss.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
