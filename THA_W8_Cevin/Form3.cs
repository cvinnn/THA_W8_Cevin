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
using MySql.Data.MySqlClient;

namespace THA_W8_Cevin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string strconn = "server=localhost;uid=root;pwd=Minato2004-05-05;database=premier_league";
        string query;

        int counter = 0;

        public Form1 rf1 { get; set; }

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        DataTable dt;

        Label lb;

        public void cmbLoad()
        {
            dt = new DataTable();

            query = "SELECT team_id as 'ID', team_name as 'Name' FROM premier_league.team;";
            conn = new MySqlConnection(strconn);
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            cbShowMatch.DataSource = dt;
            cbShowMatch.ValueMember = "ID";
            cbShowMatch.DisplayMember = "Name";
        }

        public void dgvMatchLoader(string id)
        {
            dt = new DataTable();

            query = $"SELECT m.match_id AS match_id, th.team_name AS team_home_name, ta.team_name AS team_away_name FROM premier_league.`match` m JOIN premier_league.team th ON m.team_home = th.team_id JOIN premier_league.team ta ON m.team_away = ta.team_id WHERE th.team_id = '{id}' OR ta.team_id = '{id}' order by 1;";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgShowMatch.DataSource = dt;
        }

        public void dgvDetailLoader(string id)
        {
            dt = new DataTable();
            query = $"SELECT th.team_name AS home_team, p1.player_name AS home_player_name, p1.playing_pos AS home_player_pos,ta.team_name AS away_team,p2.player_name AS away_player_name,p2.playing_pos AS away_player_pos FROM premier_league.`match` m  JOIN premier_league.team th ON m.team_home = th.team_id JOIN premier_league.team ta ON m.team_away = ta.team_id LEFT JOIN premier_league.player p1 ON m.team_home = p1.team_id LEFT JOIN premier_league.player p2 ON m.team_away = p2.team_id WHERE m.match_id = '{id}';";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgShowMatch.DataSource = dt;

            dgPlayerDetail.Visible = true;
            dt = new DataTable();
            query = $"select e.minute, t.team_name as Team_Name, p.player_name as Player_Name, CASE e.type WHEN 'GO' THEN 'Goal' WHEN 'PM' THEN 'Penalty Missed' WHEN 'GW' THEN 'Own Goal' WHEN 'GP' THEN 'Goal Penalty' WHEN 'CY' THEN 'Yellow Card' WHEN 'CR' THEN 'Red Card' ELSE e.type END AS event from premier_league.dmatch e join premier_league.team t on t.team_id = e.team_id join premier_league.player p on p.player_id = e.player_id join premier_league.match m on m.match_id = e.match_id where e.match_id = '{id}' order by 1";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgPlayerDetail.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbLoad();

            cbShowMatch.Text = "";

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            dgPlayerDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPlayerDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgShowMatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgShowMatch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void cbShowMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                counter++;
            }
            else
            {
                btnShowDetail.Visible = true;
                dgvMatchLoader(cbShowMatch.SelectedValue.ToString());
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dgShowMatch.CurrentCell;
            if (currentCell != null)
            {
                int rowIndex = currentCell.RowIndex;
                DataGridViewRow row = dgShowMatch.Rows[rowIndex];
                string id = row.Cells[0].Value.ToString();
                dgvDetailLoader(id);
            }
        }
    }
}
