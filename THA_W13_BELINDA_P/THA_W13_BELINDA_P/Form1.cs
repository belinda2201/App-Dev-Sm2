using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W13_BELINDA_P
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtNationality = new DataTable();
        DataTable dtTeamName = new DataTable();
        DataTable dtManagerTeam = new DataTable();
        DataTable dtManagerDetail = new DataTable();
        DataTable dtDeletePlayerTeam = new DataTable();
        DataTable dtShowCurrentManager = new DataTable();
        DataTable dtAllPlayer = new DataTable();
        string connection = "server=localhost;user=root;pwd=0318053478Bel.;database=premier_league";


        public Form1()
        {
            sqlConnection = new MySqlConnection(connection);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ADD PLAYER
            string command = "select nationality_id as Nation_ID, nation as Nationality from nationality;";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtNationality);
            cb_nationality.DataSource = dtNationality;
            cb_nationality.DisplayMember = "Nationality";
            cb_nationality.ValueMember = "Nation_ID";

            string command1 = "select team_id as Team_ID, team_name as Team_Name from team;";
            sqlCommand = new MySqlCommand(command1, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamName);
            cb_teamName.DataSource = dtTeamName;
            cb_teamName.DisplayMember = "Team_Name";
            cb_teamName.ValueMember = "Team_ID";

            cb_nationality.Text = "";
            cb_teamName.Text = "";

            //EDIT MANAGER
            string command2 = "select team_id as Team_ID, team_name as Team_Name from team;";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtManagerTeam);
            cb_teamManager.DataSource = dtManagerTeam;
            cb_teamManager.DisplayMember = "Team_Name";
            cb_teamManager.ValueMember = "Team_ID";

            string editManager = "select m.manager_id, m.manager_name, m.birthdate, n.nation\r\nfrom manager m, nationality n\r\nwhere m.nationality_id = n.nationality_id and working = 0;\r\n";
            sqlCommand = new MySqlCommand(editManager, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtManagerDetail);
            dgv_manager.DataSource = dtManagerDetail;

            cb_teamManager.Text = "";

            //DELETE PLAYER
            string command3 = "select team_id as Team_ID, team_name as Team_Name from team;";
            sqlCommand = new MySqlCommand(command3, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtDeletePlayerTeam);
            cb_delPlayerTeam.DataSource = dtDeletePlayerTeam;
            cb_delPlayerTeam.DisplayMember = "Team_Name";
            cb_delPlayerTeam.ValueMember = "Team_ID";
            cb_delPlayerTeam.Text = "";
        }

        private void btn_addPlayer_Click(object sender, EventArgs e)
        {
            dtAllPlayer.Clear();
            string add = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate\r\nfrom player p, nationality n\r\nwhere p.nationality_id=n.nationality_id && p.status=1;";
            sqlCommand = new MySqlCommand(add, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAllPlayer);
            txt_idPlayer.Clear();
            txt_namaPlayer.Clear();
            txt_beratPlayer.Clear();
            txt_tinggiPlayer.Clear();
            txt_nomorPlayer.Clear();
            txt_pos.Clear();
            cb_nationality.Text = "";
            cb_teamName.Text = "";
        }

        private void btn_editManager_Click(object sender, EventArgs e)
        {
            string editManager = "update team set manager_id = '" + dgv_manager.CurrentRow.Cells[0].Value.ToString() + "' WHERE team_id = '" + cb_teamManager.SelectedValue.ToString() + "';";
            runSQL(editManager);
            string edit2 = "update manager set working = 0 WHERE manager_id = '" + dgv_currentManager.CurrentRow.Cells[0].Value.ToString() + "';";
            runSQL(edit2);
            string edit3 = "update manager set working = 1 WHERE manager_id =  '" + dgv_manager.CurrentRow.Cells[0].Value.ToString() + "';";
            runSQL(edit3);
            updateDGVManager();
            dgv_manager.ClearSelection();
        }

        private void runSQL(string command)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateDGVManager()
        {
            try
            {
                dtShowCurrentManager.Clear();
                string select = "select m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation\r\nfrom manager m, team t, nationality n\r\nwhere t.manager_id=m.manager_id && n.nationality_id=m.nationality_id && t.team_id = '" + cb_teamManager.SelectedValue.ToString() + "' && t.team_name is not null;";
                sqlConnection = new MySqlConnection(connection);
                sqlCommand = new MySqlCommand(select, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtShowCurrentManager);
                dgv_currentManager.DataSource = dtShowCurrentManager;
                dgv_currentManager.ClearSelection();

                dtManagerDetail.Clear();
                string select2 = "select m.manager_id, m.manager_name, n.nation, m.birthdate FROM manager m left join nationality n ON n.nationality_id = m.nationality_id WHERE m.working = 0;";
                sqlCommand = new MySqlCommand(select2, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtManagerDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void cb_teamManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtShowCurrentManager.Clear();
            string show = "select m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation\r\nfrom manager m, team t, nationality n\r\nwhere t.manager_id=m.manager_id && n.nationality_id=m.nationality_id && t.team_id = '" + cb_teamManager.SelectedValue.ToString() + "' && t.team_name is not null;";
            sqlCommand = new MySqlCommand(show, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtShowCurrentManager);
            dgv_currentManager.DataSource = dtShowCurrentManager;
            dgv_currentManager.ClearSelection(); 
        }

        private void cb_delPlayerTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtAllPlayer.Clear();
            if (cb_delPlayerTeam.SelectedItem != null)
            {
                string searchTeam = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name\r\nfrom player p join nationality n on p.nationality_id=n.nationality_id\r\njoin team t on t.team_id=p.team_id\r\nwhere p.status=1 && t.team_id = '" + cb_delPlayerTeam.SelectedValue.ToString() + "';";
                sqlCommand = new MySqlCommand(searchTeam, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtAllPlayer);
                dgv_player.DataSource = dtAllPlayer;
            }
        }

        private void btn_deletePlayer_Click(object sender, EventArgs e)
        {
            int rows = dtAllPlayer.Rows.Count;
            if (cb_delPlayerTeam.SelectedItem != null)
            {
                if (rows >= 11)
                {
                    if (dgv_player.SelectedRows.Count != 0)
                    {
                        string update = "update player set status = 0 where player_name = '" + dgv_player.SelectedRows[0].Cells["player_name"].Value.ToString() + "';";
                        sqlCommand = new MySqlCommand(update, sqlConnection);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        dtAllPlayer.Clear();
                        string select = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name\r\nfrom player p join nationality n on p.nationality_id=n.nationality_id\r\njoin team t on t.team_id=p.team_id\r\nwhere p.status=1;";
                        sqlCommand = new MySqlCommand(select, sqlConnection);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dtAllPlayer);
                    }
                }
                else
                {
                    MessageBox.Show("Players are less than 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
