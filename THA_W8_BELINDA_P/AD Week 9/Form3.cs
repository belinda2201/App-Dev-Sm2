using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AD_Week_9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;uid=root;pwd=0318053478Bel.;database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataReader sqlDataReader;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtDMatch = new DataTable();
        DataTable dtTeamHome = new DataTable();
        DataTable dtTeamAway = new DataTable();
        DataTable dtMatchDetail = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectionString);
            sqlQuery = "select team_name as `Team Name` from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cb_team.DataSource = dtTeam;
            cb_team.DisplayMember = "Team Name";
            cb_team.ValueMember = "Team Name";

            if (cb_match.Text == "" && cb_match.Text == "")
            {
                btn_search.Enabled = false;
            }
            cb_match.Text = "";
            cb_team.Text = "";
        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtMatch = new DataTable();
            sqlQuery = "select m.match_date as `Match Date`, t.team_name as `Team Home`, t1.team_name as `Team Away`, m.match_id as `ID Match` from team t, team t1, `match` m where (t.team_name = '" + cb_team.SelectedValue.ToString() +"' or t1.team_name = '" + cb_team.SelectedValue.ToString() + "') and t.team_id = m.team_home and t1.team_id = m.team_away;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);

            cb_match.DataSource = dtMatch;
            cb_match.ValueMember = "ID Match";
            cb_match.DisplayMember = "Match Date";
            cb_match.Text = "";
            btn_search.Enabled = false;

            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_match.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cb_match.SelectedItem;
                label_teamHome.Text = selectedRow["Team Home"].ToString();
                label_teamAway.Text = selectedRow["Team Away"].ToString();
            }

            dtTeamHome = new DataTable();
            sqlQuery = "select t.team_name as `Team Name`, p.player_name as `Player Name`, if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'Position' from player p, team t where p.team_id = t.team_id and t.team_name = '" + label_teamHome.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            dgv_teamHome.DataSource = dtTeamHome;

            dtTeamAway = new DataTable();
            sqlQuery = "select t.team_name as `Team Name`, p.player_name as `Player Name`, if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'Position' from player p, team t where p.team_id = t.team_id and t.team_name = '" + label_teamAway.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamAway);
            dgv_teamAway.DataSource = dtTeamAway;

            dtMatchDetail = new DataTable();
            sqlQuery = "select d.minute as `Minutes`, t.team_name as `Team Name`, p.player_name as `Player Name`, if(d.type = 'CY', 'Yellow Card (CY)', if (d.type = 'CR', 'Red Card (CR)',if (d.type = 'GO', 'Goal (GO)', if (d.type = 'GW', 'Own Goal (GW)', if (d.type = 'GP', 'Goal Penalty (GP)', 'Penalty Missed (PM)'))))) as `Type` from dmatch d, team t, player p where t.team_id = d.team_id and p.player_id = d.player_id and d.match_id = '" + cb_match.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchDetail);
            dgv_detailMatch.DataSource = dtMatchDetail;
        }

        private void cb_match_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtDMatch = new DataTable();
            sqlQuery = "select t.team_name as `Team Home`, t1.team_name as `Team Away` from `match` m, team t, team t1 where m.team_home = t.team_id and m.team_away = t1.team_id and m.match_id = '" + cb_team.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDMatch);
            btn_search.Enabled = true;

        }
    }
}
