using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using reportCard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportCard
{
    public partial class Login : MetroForm
    {
        public event EventHandler LogInSuccess;
        Form _owner = null;
        private Form owner;
        public Login()
        {
            InitializeComponent();
        }
        void SaveSettings()
        {
            Settings.Default.Server = txtServer.Text;
            Settings.Default.Database = txtDB.Text;
            Settings.Default.Port = txtPortNo.Text;
            Settings.Default.Username = txtUser.Text;
            Settings.Default.Password = txtPass.Text;
        }
        private bool TestCon(bool nomessage = false)
        {
            bool _return = true;
            string _message = "Successfully established a connection!";
            MessageBoxIcon _icon = MessageBoxIcon.Information;
            SaveSettings();

            if (!Functions.TestConnection())
            {
                _message = "Failed to establish a connection using the specified connection values!";
                _icon = MessageBoxIcon.Error;
                _return = false;
            }

            if (!nomessage) MessageBox.Show(_owner, _message, Application.ProductName, MessageBoxButtons.OK, _icon);

            return _return;
        }
        private void metroLink3_Click(object sender, EventArgs e)
        {
                //Database Connection string
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Settings.Default.Server;
                builder.UserID = Settings.Default.Username;
                builder.Password = Settings.Default.Password;
                builder.Database = Settings.Default.Database;
                MySqlConnection connection = new MySqlConnection(builder.ToString());

                if (!TestCon(true)) return;
                string _sql = "select * from reportcard.user where UserID = '" + this.txtUsername.Text + "' and Password='" + this.txtPassword.Text + "'; ";
                DataTable _table = Functions.DataTable(_sql);
                if (_table.Rows.Count > 0)
                {
                    if (_table.Rows[0].Field<string>("Password") != txtPassword.Text)
                    {
                        txtPassword.Clear();
                        txtPassword.Focus();
                        MetroFramework.MetroMessageBox.Show(_owner, "Invalid password!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    MetroFramework.MetroMessageBox.Show(_owner, "Username not found!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((UserType.Text == "Administrator"))
                {
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.ShowDialog();
                    d.Dispose();

                }
                if ((UserType.Text == "Staff"))
                {
                    this.Hide();
                    AddMarks a = new AddMarks();
                    a.ShowDialog();
                    a.Dispose();
                }
         }
        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password change_Password = new Change_Password();
            change_Password.Show();
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {

            {
                if (MessageBox.Show("Do you want to close this application?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {

            SaveSettings();
            TestCon();
        }
    }
}
