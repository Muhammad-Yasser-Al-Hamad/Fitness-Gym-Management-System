using System;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void showSection(UserControl section)
        {
            panelContent.Controls.Clear();
            section.Dock = DockStyle.Fill;
            panelContent.Controls.Add(section);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSection(new UC_AddMember());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSection(new UC_ViewMembers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSection(new UC_ManageSessions());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSection(new UC_ManageSubscriptions());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSection(new UC_ManageUsers());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSection(new UC_About());
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
        }
    }
}