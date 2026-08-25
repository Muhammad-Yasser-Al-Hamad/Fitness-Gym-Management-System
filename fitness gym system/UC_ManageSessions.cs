using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_ManageSessions : UserControl
    {
        public UC_ManageSessions()
        {
            InitializeComponent();
        }

        private void UC_ManageSessions_Load(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void LoadSessions()
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sessions", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSessions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Sessions (SessionName, CoachName, SessionDate, SessionTime, Price) VALUES (@name, @coach, @date, @time, @price)", con);
                cmd.Parameters.AddWithValue("@name", txtSessionName.Text);
                cmd.Parameters.AddWithValue("@coach", txtCoachName.Text);
                cmd.Parameters.AddWithValue("@date", dtpSessionDate.Value);
                cmd.Parameters.AddWithValue("@time", txtSessionTime.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Session saved successfully!");
                LoadSessions();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (dgvSessions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvSessions.SelectedRows[0].Cells["SessionID"].Value);
                    SqlConnection con = DB.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Sessions WHERE SessionID = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Session deleted!");
                    LoadSessions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClearSession_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtSessionName.Text = "";
            txtCoachName.Text = "";
            txtSessionTime.Text = "";
            txtPrice.Text = "";
        }

        private void dgvSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSessionName.Text = dgvSessions.Rows[e.RowIndex].Cells["SessionName"].Value.ToString();
                txtCoachName.Text = dgvSessions.Rows[e.RowIndex].Cells["CoachName"].Value.ToString();
                txtSessionTime.Text = dgvSessions.Rows[e.RowIndex].Cells["SessionTime"].Value.ToString();
                txtPrice.Text = dgvSessions.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }
    }
}