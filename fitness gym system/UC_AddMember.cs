using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // ضفنا المكتبة دي عشان نقدر نكلم SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_AddMember : UserControl
    {
        public UC_AddMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // مش محتاجين نكتب حاجة هنا
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ده كود زرار الـ Save
            try
            {
                using (SqlConnection conn = DB.GetConnection())
                {
                    // استعلام الإضافة للجدول اللي عملناه في SQL
                    string query = "INSERT INTO Members (MemberName, PhoneNumber, SubscriptionType) VALUES (@name, @phone, @sub)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // ربط البيانات بالـ TextBoxes (تأكد إن أساميهم textBox1 و 2 و 3)
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox2.Text);
                    cmd.Parameters.AddWithValue("@sub", textBox3.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // تنفيذ الأمر

                    MessageBox.Show("The member has been added successfully!");

                    // تنضيف الخانات بعد الحفظ
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                // لو فيه غلط في اسم السيرفر أو الجدول هيظهر هنا
                MessageBox.Show("There was a problem: " + ex.Message);
            }
        }

        private void UC_AddMember_Load(object sender, EventArgs e)
        {

        }
    }
}