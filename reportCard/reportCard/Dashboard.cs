using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportCard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void customImageButton1_Click(object sender, EventArgs e)
        {
            this.Show();
            AddStudents addstudents = new AddStudents();
            addstudents.Show();
        }
        private void customImageButton2_Click(object sender, EventArgs e)
        {
            this.Show();
            AddMarks addmarks = new AddMarks();
            addmarks.Show();
        }
        private void customImageButton3_Click(object sender, EventArgs e)
        {
            this.Show();
            Students_Results_Search results_Search = new Students_Results_Search();
            results_Search.Show();
        }
        private void customImageButton4_Click(object sender, EventArgs e)
        {

            {
                if (MessageBox.Show("Do you want to close this application?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void customImageButton5_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Do you want to Logout?", "Logout Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
        }
        private void customImageButton6_Click(object sender, EventArgs e)
        {
            this.Show();
            User_Registration user = new User_Registration();
            user.Show();
        }
        private void customImageButton8_Click(object sender, EventArgs e)
        {
            this.Show();
            About a = new About();
            a.ShowDialog();
            a.Dispose();
        }
        private void customImageButton7_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Do you want to Minimized this application?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }
        private void customImageButton9_Click(object sender, EventArgs e)
        {
            this.Show();
            Student_Search results_Search = new Student_Search();
            results_Search.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com");
            Process.Start(sInfo);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://twitter.com/");
            Process.Start(sInfo);            
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.instagram.com/");
            Process.Start(sInfo);
        }
    }
}
