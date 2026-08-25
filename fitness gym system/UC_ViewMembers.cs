using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_ViewMembers : UserControl
    {
        // هنعرف DataTable بره عشان نستخدمها في الفلترة السريعة (Live Search)
        DataTable dtMembers = new DataTable();

        public UC_ViewMembers()
        {
            InitializeComponent();
        }

        private void UC_ViewMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        // دالة جلب الأعضاء - محسنة لإدارة الموارد
        private void LoadMembers()
        {
            try
            {
                using (SqlConnection con = DB.GetConnection())
                {
                    string query = "SELECT * FROM Members";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    dtMembers = new DataTable(); // إعادة تهيئة الجدول
                    da.Fill(dtMembers);
                    dgvMembers.DataSource = dtMembers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // زرار Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear(); // نمسح نص البحث
            LoadMembers();
        }

        // تم نقل منطق البحث ليكون "لحظي" داخل الـ TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // الفلترة هنا بتتم في الذاكرة (Memory) سريعة جداً ومش بتهنج البرنامج
                DataView dv = dtMembers.DefaultView;
                dv.RowFilter = string.Format("MemberName LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%'", txtSearch.Text);
                dgvMembers.DataSource = dv.ToTable();
            }
            catch
            {
                // في حالة وجود رموز غريبة في البحث لا تسبب توقف البرنامج
            }
        }

        // زرار Delete - محسن مع تأكيد الحذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("من فضلك حدد العضو المراد حذفه من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف هذا العضو نهائياً؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // جلب الـ ID من الصف المحدد
                    int memberID = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

                    using (SqlConnection con = DB.GetConnection())
                    {
                        con.Open();
                        string query = "DELETE FROM Members WHERE MemberID = @id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", memberID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("تم حذف العضو بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); // تحديث الجدول بعد الحذف
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء الحذف: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // زرار الـ Search القديم ممكن تخليه يفرغ الخانة أو يعمل Refresh
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // بما إننا عملنا البحث لحظي، الزرار ده مبقاش ليه لزمة كبيرة
            // ممكن نخليه ينفذ نفس كود الـ TextChanged للتأكيد
            txtSearch_TextChanged(null, null);
        }
    }
}