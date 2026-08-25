using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_ManageSubscriptions : UserControl
    {
        public UC_ManageSubscriptions()
        {
            InitializeComponent();
        }

        private void UC_ManageSubscriptions_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadSessions();
            LoadSubscriptions();
        }

        private void LoadMembers()
        {
            SqlConnection con = DB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MemberID, MemberName FROM Members", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMember.DataSource = dt;
            cmbMember.DisplayMember = "MemberName";
            cmbMember.ValueMember = "MemberID";
        }

        private void LoadSessions()
        {
            SqlConnection con = DB.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SessionID, SessionName FROM Sessions", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSession.DataSource = dt;
            cmbSession.DisplayMember = "SessionName";
            cmbSession.ValueMember = "SessionID";
        }

        private void LoadSubscriptions()
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                string query = @"SELECT s.SubscriptionID, m.MemberName, se.SessionName, 
                                s.StartDate, s.EndDate, s.Amount 
                                FROM Subscriptions s
                                JOIN Members m ON s.MemberID = m.MemberID
                                JOIN Sessions se ON s.SessionID = se.SessionID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSubscriptions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSaveSub_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Subscriptions (MemberID, SessionID, StartDate, EndDate, Amount) VALUES (@mid, @sid, @start, @end, @amount)", con);
                cmd.Parameters.AddWithValue("@mid", cmbMember.SelectedValue);
                cmd.Parameters.AddWithValue("@sid", cmbSession.SelectedValue);
                cmd.Parameters.AddWithValue("@start", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@end", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription saved!");
                LoadSubscriptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            if (dgvSubscriptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subscription to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvSubscriptions.SelectedRows[0].Cells["SubscriptionID"].Value);
                    SqlConnection con = DB.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Subscriptions WHERE SubscriptionID = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Subscription deleted!");
                    LoadSubscriptions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}