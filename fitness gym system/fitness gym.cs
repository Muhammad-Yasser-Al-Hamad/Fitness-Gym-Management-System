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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fitness_gym_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked==false)
               txtPass.UseSystemPasswordChar=true;
           else
                txtPass.UseSystemPasswordChar=false;
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // بنستخدم كلاس DB اللي عملناه عشان نفتح الاتصال
                using (SqlConnection conn = DB.GetConnection())
                {
                    // جملة الاستعلام: هل اليوزر والباسورد موجودين؟
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // لاحظ هنا: استخدمت textBox1 لليوزر و txtPass للباسورد بناءً على الكود بتاعك
                    cmd.Parameters.AddWithValue("@user", textName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("\r\nLogin successful!");

                        // فتح الشاشة الرئيسية اللي ميرنا عملتها
                        MainForm2 main = new MainForm2();
                        main.Show();
                        this.Hide(); // إخفاء شاشة اللوجن
                    }
                    else
                    {
                        MessageBox.Show("The information is incorrect. Please double-check your name and password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem connecting to the server: " + ex.Message);
            }
        }
    }
}
