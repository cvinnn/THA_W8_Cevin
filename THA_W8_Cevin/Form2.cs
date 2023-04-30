using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string strconn = "server=localhost;uid=root;pwd=Minato2004-05-05;database=premier_league";
        string query;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public Form1 rf1 { get; set; }

        DataTable dt;

        Label lb;

        int count = 0;

        public void cmbLoad()
        {
            dt = new DataTable();

            query = "SELECT team_id as 'ID', team_name as 'Name' FROM premier_league.team;";
            conn = new MySqlConnection(strconn);
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            cbPlayerData.DataSource = dt;
            cbPlayerData.ValueMember = "ID";
            cbPlayerData.DisplayMember = "Name";
        }

        public void TeamListLoad(string id)
        {
            dt = new DataTable();

            query = $"SELECT player_id as 'ID P', player_name as 'Name P' FROM premier_league.player WHERE team_id = '{id}';";
            conn = new MySqlConnection(strconn);
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            cbChoosePlayer.DataSource = dt;
            cbChoosePlayer.ValueMember = "ID P";
            cbChoosePlayer.DisplayMember = "Name P";
        }

        public void PlayerLoad(string id)
        {

            string[] data = { "Player Name", "Team Name", "Player Position", "Player Nation", "Squad Number", "Yellow Card", "Red Card", "Goal Scored", "Penalty Missed" };

            for (int i = 0; i < 9; i++)
            {
                lb = new Label();
                lb.Text = data[i];
                lb.Name = "lb" + i.ToString();
                lb.Location = new Point(50, 40 * i + 60);
                lb.Size = new Size(200, 40);
                this.Controls.Add(lb);

            }

            dt = new DataTable();

            query = $"SELECT p.player_name as 'Player Name', t.team_name as 'Team Name', p.playing_pos as 'Player Position', n.nation as 'Player Nation', p.team_number as 'Squad Number',COALESCE(SUM(IF(d.`type` = 'CY', 1, 0)), 0) as 'Yellow Card', COALESCE(SUM(IF(d.`type` = 'CR', 1, 0)), 0) as 'Red Card', COALESCE(SUM(IF(d.`type` = 'GO', 1, 0)), 0) as 'Goal Scored', COALESCE(SUM(IF(d.`type` = 'PM', 1, 0)), 0) as 'Penalty Missed' FROM premier_league.player p JOIN premier_league.team t ON t.team_id = p.team_id JOIN premier_league.nationality n ON p.nationality_id = n.nationality_id LEFT JOIN premier_league.dmatch d ON d.player_id = p.player_id WHERE p.player_id = '{id}' GROUP BY 1, 2, 3, 4, 5;";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    lb = new Label();
                    lb.Text = dt.Rows[0][i].ToString();
                    lb.Name = "lb" + i.ToString() + dt.Rows[0][0].ToString();
                    lb.Location = new Point(300, 40 * i + 60);
                    lb.Size = new Size(200, 40);
                    this.Controls.Add(lb);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbLoad();

            this.Dock = DockStyle.Fill;
            this.TopLevel = false;

            cbPlayerData.Text = "";
            cbChoosePlayer.Text = "";
        }

        private void cbPlayerData_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }
            if (count == 0)
            {
                count++;
            }
            else if (count > 0)
            {
                TeamListLoad(cbPlayerData.SelectedValue.ToString());
                cbChoosePlayer.Enabled = true;
                cbChoosePlayer.Text = "";
                count = 1;
            }
        }

        private void cbChoosePlayer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }
            if (count < 3)
            {
                count++;
            }
            else
            {
                PlayerLoad(cbChoosePlayer.SelectedValue.ToString());
            }
        }
    }
}
