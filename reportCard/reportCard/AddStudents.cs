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
    public partial class AddStudents : MetroForm
    {
        public AddStudents()
        {
            InitializeComponent();
        }
        //This generates auto ids
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txtAdmissionNo.Text = "214" + GetUniqueKey(5);
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            auto();
        }

        private void reset()
        {
            txtStudentName.Text = "";
            cmbClass.Text = "";
            cmbRI.Text = "";
            dtpAdmissionDate.Text = "";
            auto();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //String Definations
            string student_id = txtAdmissionNo.Text;
            string student_name = txtStudentName.Text;
            string reg_date = dtpAdmissionDate.Text;
            string add_class = cmbClass.Text;
            string res_info = cmbRI.Text;
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
                //Insertion Query
                string q = "insert into reportcard.student(student_id, student_name, reg_date, add_class, res_info) VALUES (@student_id, @student_name, @reg_date, @add_class, @res_info)";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                //Adding String Defination to databse table base on textbox values
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@student_name", student_name);
                newuser.Parameters.AddWithValue("@reg_date", reg_date);
                newuser.Parameters.AddWithValue("@add_class", add_class);
                newuser.Parameters.AddWithValue("@res_info", res_info);               
                newuser.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Search ss = new Student_Search();
            ss.Show();
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            //String Definations
            string student_id = txtAdmissionNo.Text;
            string student_name = txtStudentName.Text;
            string reg_date = dtpAdmissionDate.Text;
            string add_class = cmbClass.Text;
            string res_info = cmbRI.Text;

            //Database Connection string
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Settings.Default.Server;
            builder.UserID = Settings.Default.Username;
            builder.Password = Settings.Default.Password;
            builder.Database = Settings.Default.Database;
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            connection.Open();

            try
            {
                string q = "Update reportcard.student Set student_id=@student_id, student_name=@student_name, reg_date=@reg_date, add_class=@add_class, res_info=@res_info where student_id=@student_id";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@student_name", student_name);
                newuser.Parameters.AddWithValue("@reg_date", reg_date);
                newuser.Parameters.AddWithValue("@add_class", add_class);
                newuser.Parameters.AddWithValue("@res_info", res_info);
               
                newuser.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Database Connection string
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Settings.Default.Server;
            builder.UserID = Settings.Default.Username;
            builder.Password = Settings.Default.Password;
            builder.Database = Settings.Default.Database;
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            connection.Open();

            try
            {
                if (MessageBox.Show("Do you really want to Delete Records?", "Delete Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string q = "delete from student where student_id='" + txtAdmissionNo.Text + "'";
                    MySqlCommand newuser = new MySqlCommand(q, connection);
                    newuser.CommandText = q;
                    newuser.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
