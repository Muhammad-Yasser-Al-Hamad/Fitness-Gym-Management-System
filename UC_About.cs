using System;
using System.Windows.Forms;

namespace fitness_gym_system
{
    public partial class UC_About : UserControl
    {
        public UC_About()
        {
            InitializeComponent();
        }

        private void UC_About_Load(object sender, EventArgs e)
        {
            rtbRequirements.Text =
@"  A modern and efficient system designed for comprehensive gym 
      management, including member registration, coach tracking,
session scheduling, and subscription services. Built on the latest C# 
      and SQL Server technologies to provide a high-performance
                                               experience.";
        }

        private void rtbRequirements_TextChanged(object sender, EventArgs e)
        {

        }
    }
}