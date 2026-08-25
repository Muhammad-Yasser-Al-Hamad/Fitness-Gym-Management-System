using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_ManageUsers : UserControl
    {
        public UC_ManageUsers()
        {
            InitializeComponent();
        }

        private void UC_ManageUsers_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Coach", "Trainee" });
            cmbRole.SelectedIndex = 0;
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DB.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (Username, Password, Role) VALUES (@user, @pass, @role)", con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User saved!");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                    SqlConnection con = DB.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User deleted!");
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = 0;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }
    }
}