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

namespace W13_Praktikum_RyanGunawan_0706022110024
{
    public partial class Form_Player : Form
    {
        public Form_Player()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPlayer = new DataTable();
        DataTable dtNation = new DataTable();
        DataTable dtTeam = new DataTable();
        int PosisiSekarang = 0;


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id, p.player_name, p.birthdate, n.nation as 'Asal', t.team_name as 'Nama Tim', p.team_number, p.status FROM player p, nationality n, team t WHERE p.nationality_id = n.nationality_id and p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            sqlAdapter.Fill(dtNation);
            sqlAdapter.Fill(dtTeam);
            cb_Nationality.DataSource = dtNation;
            cb_Nationality.DisplayMember = "Asal";
            cb_Team.DataSource = dtTeam;
            cb_Team.DisplayMember = "Nama Tim";
            DataPemain(0);
            
        }

        public void DataPemain (int Posisi)
        {
            tBox_ID.Text = dtPlayer.Rows[Posisi][0].ToString();
            tBox_Nama.Text = dtPlayer.Rows[Posisi][1].ToString();
            Box_birthDate.Text = dtPlayer.Rows[Posisi][2].ToString();
            cb_Nationality.Text = dtPlayer.Rows[Posisi][3].ToString();
            cb_Team.Text = dtPlayer.Rows[Posisi][4].ToString();
            Nmbr_Team.Text = dtPlayer.Rows[Posisi][5].ToString();
            if (dtPlayer.Rows[Posisi][6].ToString().Length == 4)
            {
                lbl_Status.Text = "Available";
            }
            else
            {
                lbl_Status.Text = "Not Available";
            }
            PosisiSekarang = Posisi;
        }

		private void btn_First_Click_1(object sender, EventArgs e)
		{
            DataPemain(0);
        }

		private void btn_Prev_Click_1(object sender, EventArgs e)
		{
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

		private void btn_Next_Click_1(object sender, EventArgs e)
		{
            if (PosisiSekarang < dtPlayer.Rows.Count - 1)
            {
                PosisiSekarang++;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

		private void btn_Last_Click_1(object sender, EventArgs e)
		{
            DataPemain(dtPlayer.Rows.Count - 1);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sqlQuery = "UPDATE player SET player_name = '" + tBox_Nama.Text + "',  birthdate = '" + Box_birthDate.Text + "', nationality_id = '" + cb_Nationality.Text + "', team_id = '" + cb_Team.Text + "', team_number = '" + Nmbr_Team.Text + "' WHERE player_id = '" + tBox_ID.Text + "';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil Disimpan");
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
		{
            this.Close();
		}


	}
}
