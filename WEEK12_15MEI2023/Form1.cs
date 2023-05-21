using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WEEK12_15MEI2023
{
    public partial class Form1 : Form
    {
        string sqlQuery;
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionString;
        DataTable dtnation = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dtmanagerdetail = new DataTable();
        DataTable dtmanagerdetail1 = new DataTable();
        DataTable dtplayerlist = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=db_theo";
            sqlQuery = "select nationality_id nationid, nation nationality from nationality;";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtnation);
            CB_nationality.DataSource = dtnation;
            CB_nationality.ValueMember = "nationid";
            CB_nationality.DisplayMember = "nationality";
            sqlQuery = "select team_id,team_name from team;";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            CB_teamname.DataSource = dtteam;
            CB_teamname.ValueMember = "team_id";
            CB_teamname.DisplayMember = "team_name";
            CB_teamname2.DataSource = dtteam;
            CB_teamname2.ValueMember = "team_id";
            CB_teamname2.DisplayMember = "team_name";
            CB_teamname1.DataSource = dtteam;
            CB_teamname1.ValueMember = "team_id";
            CB_teamname1.DisplayMember = "team_name";
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripADD_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = true;
            paneleditmanager.Visible = false;
        }

        private void toolStripEDIT_Click(object sender, EventArgs e)
        {
            paneladdplayer.Visible = false;
            paneleditmanager.Visible = true;
        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            string command = $"insert into player values('{textBox_playerid.Text}','{tb_teamnum.Text}','{tb_name.Text}','{CB_nationality.SelectedValue.ToString()}','{tb_pos.Text}','{tb_height.Text}','{tb_weight.Text}','{date_birth.Value.ToString("yyyy/MM/dd")}','{CB_teamname.SelectedValue.ToString()}','1','0')";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
        string x = "";

        private void CB_teamname2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_teamname2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtmanagerdetail.Clear();

            sqlQuery = $"select m.manager_id,m.manager_name,t.team_name,m.birthdate, m.nationality_id, m.working from manager m left join team t on m.manager_id = t.manager_id where t.team_id = '{CB_teamname.SelectedValue.ToString()}';";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmanagerdetail);
            x = dtmanagerdetail.Rows[0][0].ToString();
            dgv_manager1.DataSource = dtmanagerdetail;
            dtmanagerdetail1.Clear();
            sqlQuery = $"select m.manager_id,m.manager_name,m.birthdate, m.nationality_id, m.working from manager m  where m.working = '0';";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtmanagerdetail1);
            dgv_manager2.DataSource = dtmanagerdetail1;
        }

        private void butt_update_Click(object sender, EventArgs e)
        {
            string command = $"update team set manager_id = '{idbaru}' where team_id = '{CB_teamname.SelectedValue}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
            command = $"update manager set working = '0' where manager_id = '{x}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
            command = $"update manager set working = '1' where manager_id = '{idbaru}';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(command, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(command, ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
        string idbaru = " ";

        private void dgv_manager2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbaru = dtmanagerdetail1.Rows[e.RowIndex][0].ToString();
        }

        private void CB_teamname1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sqlQuery = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{CB_teamname1.SelectedValue.ToString()}' and n.nationality_id = p.nationality_id and p.status = '1';";
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayerlist);
            dgv_team.DataSource = dtplayerlist;
            dgv_team.Columns.Remove("player_id");
        }

        private void butt_delete_Click(object sender, EventArgs e)
        {
            if (dtplayerlist.Rows.Count < 11)
            {
                MessageBox.Show("KURANG DR 11");
            }
            else
            {
                string command = $"update player set status = '0' where player_id = '{idbaru2}';";
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand(command, conn);
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(command, ex.Message);

                }
                finally
                {
                    conn.Close();
                }
                dtplayerlist.Clear();
                sqlQuery = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{CB_teamname1.SelectedValue.ToString()}' and n.nationality_id = p.nationality_id and p.status = '1';";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sqlQuery, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtplayerlist);
                dgv_team.DataSource = dtplayerlist;
            }


        }
        string idbaru2 = "";

        private void dgv_team_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbaru2 = dtplayerlist.Rows[e.RowIndex][0].ToString();
        }
    }
}
