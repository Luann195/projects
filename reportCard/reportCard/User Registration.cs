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
    public partial class User_Registration : MetroForm
    {
        private MySqlDataReader rdr;

        public User_Registration()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtContactNo.Text = "";
            txtEmailID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            cmbUserType.SelectedIndex = -1;
            txtUserID.Focus();
            txtDate.Text = "";
            
        }
        private void txtEmailID_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmailID.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmailID.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (txtUserID.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtUserID.Text))
                {
                    MessageBox.Show("only letters,numbers and underscore is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        public void GetData()
        {
            try
            {

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Settings.Default.Server;
                builder.UserID = Settings.Default.Username;
                builder.Password = Settings.Default.Password;
                builder.Database = Settings.Default.Database;
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                String sql = "SELECT RTRIM(ID), RTRIM(userid), RTRIM(UserType), RTRIM(Password), RTRIM(Name), RTRIM(EmailID), RTRIM(ContactNo),RTRIM(JoiningDate) from user order by JoiningDate";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                DataTable _table = Functions.DataTable(sql);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgw.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UserID = txtUserID.Text;
            string UserType = cmbUserType.Text;
            string Password = txtPassword.Text;
            string Name = txtName.Text;
            string ContactNo = txtContactNo.Text;
            string EmailID = txtEmailID.Text;
            string Date = txtDate.Text;


            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Settings.Default.Server;
                builder.UserID = Settings.Default.Username;
                builder.Password = Settings.Default.Password;
                builder.Database = Settings.Default.Database;
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                
                string q = "insert into reportcard.user(UserID,UserType,Password,Name,ContactNo,EmailID,JoiningDate) VALUES (@UserID,@UserType,@Password,@Name,@ContactNo,@EmailID,@JoiningDate)";
                MySqlCommand cc = new MySqlCommand(q, connection);
                cc.CommandText = q;
                cc.Parameters.AddWithValue("@UserID", UserID);
                cc.Parameters.AddWithValue("@UserType", UserType);
                cc.Parameters.AddWithValue("@Password", Password);
                cc.Parameters.AddWithValue("@Name", Name);
                cc.Parameters.AddWithValue("@ContactNo", ContactNo);
                cc.Parameters.AddWithValue("@EmailID", EmailID);
                cc.Parameters.AddWithValue("@JoiningDate", Date);
                cc.ExecuteReader();
                GetData();
                btnSave.Enabled = false;
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string UserID = txtUserID.Text;
            string UserType = cmbUserType.Text;
            string Password = txtPassword.Text;
            string Name = txtName.Text;
            string ContactNo = txtContactNo.Text;
            string EmailID = txtEmailID.Text;
            string JoiningDate = txtDate.Text;
            try
            {
                //Database Connection string
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Settings.Default.Server;
                builder.UserID = Settings.Default.Username;
                builder.Password = Settings.Default.Password;
                builder.Database = Settings.Default.Database;
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                string q = "Update reportcard.user Set UserID=@UserID, UserType=@UserType, Password=@Password, Name=@Name, ContactNo=@ContactNo, EmailID=@EmailID, JoiningDate=@JoiningDate  where UserID=@UserID";
                MySqlCommand cc = new MySqlCommand(q, connection);
                cc.CommandText = q;
                cc.Parameters.AddWithValue("@UserID", UserID);
                cc.Parameters.AddWithValue("@UserType", UserType);
                cc.Parameters.AddWithValue("@Password", Password);
                cc.Parameters.AddWithValue("@Name", Name);
                cc.Parameters.AddWithValue("@ContactNo", ContactNo);
                cc.Parameters.AddWithValue("@EmailID", EmailID);
                cc.Parameters.AddWithValue("@JoiningDate", JoiningDate);
                cc.ExecuteNonQuery();
                GetData();
                btnUpdate.Enabled = false;
                MessageBox.Show("Successfully updated", "User Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_records()
        {

            try
            {
                if (txtUserID.Text == "admin")
                {
                    MessageBox.Show("Admin Account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int RowsAffected = 0;
                //Database Connection string
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = Settings.Default.Server;
                builder.UserID = Settings.Default.Username;
                builder.Password = Settings.Default.Password;
                builder.Database = Settings.Default.Database;
                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();
                string q = "delete from user where UserID=@d1";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                newuser.Parameters.AddWithValue("@d1", txtUserID.Text);
                RowsAffected = newuser.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
                GetData();

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            GetData();
        }
    }
}