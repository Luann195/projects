using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using reportCard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace reportCard
{
    public partial class Students_Results_Search : MetroForm
    {
        private MySqlDataReader rdr;
        public Students_Results_Search()
        {
            InitializeComponent();
        }
        private void order()
        {
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
           string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks ORDER BY year ASC, total_marks DESC";
           MySqlCommand newuser = new MySqlCommand(sql, connection);
           rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
           dtSN.Rows.Clear();
           while (rdr.Read() == true)
                {
                    dtSN.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void orderDate()
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where entry_date like '" + txtDate.Text+ "%' ORDER BY term DESC, year DESC, class_form DESC, total_marks DESC";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtDate.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtDate.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void maxMarksDate()
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where year like '"+cmbAcademicYP.Text+ "%' ORDER BY year DESC, total_marks DESC";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void maxMarksTerm()
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where term like '" +cmbTerm.Text+ "%' ORDER BY term DESC, total_marks DESC";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void maxMarksForm()
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where class_form like '" +cmbForm.Text+ "%' ORDER BY class_form DESC, total_marks DESC";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EntryDate()
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where entry_date like '" + dateEntry.Text + "%' ORDER BY entry_date DESC, total_marks DESC";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GET()
        {
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
                String sql = "select distinct RTRIM(student_id) from marks";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                newuser.Connection = connection;

                rdr = newuser.ExecuteReader();
                while (rdr.Read())
                {
                    cmbStudent.Items.Add(rdr[0]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void academic()
        {
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
                String sql = "select distinct RTRIM(year) from marks";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                newuser.Connection = connection;

                rdr = newuser.ExecuteReader();
                while (rdr.Read())
                {
                    cmbAcademicYear.Items.Add(rdr[0]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void academicP()
        {
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
                String sql = "select distinct RTRIM(year) from marks";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                newuser.Connection = connection;
                rdr = newuser.ExecuteReader();
                while (rdr.Read())
                {
                    cmbAcademicYP.Items.Add(rdr[0]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where student_name like '" + txtSName.Text + "%' order by student_name";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtSN.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtSN.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dtSN.Rows.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where student_id like '"+cmbStudent.Text+ "%' order by student_id";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtSID.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtSID.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where entry_date like '"+txtDate.Text+ "%' order by entry_date";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtDate.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtDate.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Students_Results_Search_Load(object sender, EventArgs e)
        {
            GET();
            academic();
            academicP();
        }
        private void button3_Click(object sender, EventArgs e)
        {
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
                string sql = " select RTRIM(student_id),RTRIM(student_name),RTRIM(class_form),RTRIM(year),RTRIM(term),RTRIM(entry_date),RTRIM(english_em),RTRIM(maths_em),RTRIM(rme_em),RTRIM(science_em),RTRIM(french_em),RTRIM(twi_em),RTRIM(ict_em),RTRIM(social_em),RTRIM(bdt_em),RTRIM(total_marks) from reportcard.marks where year like '" +cmbAcademicYear.Text+ "%' order by year";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dtDate.Rows.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            dtSID.Rows.Clear();
        }
        private void dtSN_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dtSN.SelectedRows[0];
                this.Show();
                AddMarks frm = new AddMarks();
                frm.Show();
                frm.txtStudentNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.txtClass.Text = dr.Cells[2].Value.ToString();
                frm.txtAcademic.Text = dr.Cells[3].Value.ToString();
                frm.txtTerm.Text = dr.Cells[4].Value.ToString();
                frm.txtDate.Text = dr.Cells[5].Value.ToString();
                frm.txtEnglish.Text = dr.Cells[6].Value.ToString();
                frm.txtMaths.Text = dr.Cells[7].Value.ToString();
                frm.txtRme.Text = dr.Cells[8].Value.ToString();
                frm.txtScience.Text = dr.Cells[9].Value.ToString();
                frm.txtFrench.Text = dr.Cells[10].Value.ToString();
                frm.txtTwi.Text = dr.Cells[11].Value.ToString();
                frm.txtIct.Text = dr.Cells[12].Value.ToString();
                frm.txtSocial.Text = dr.Cells[13].Value.ToString();
                frm.txtBdt.Text = dr.Cells[14].Value.ToString();
                frm.txtTotalMarks.Text = dr.Cells[15].Value.ToString();
                frm.btnGetCA.PerformClick();
                frm.btnCal.PerformClick();
                dtSN.Refresh();
                frm.btnSave.Enabled = false;
                frm.btnUpdate_record.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtSID_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dtSID.SelectedRows[0];
                this.Show();
                AddMarks frm = new AddMarks();
                frm.Show();
                frm.txtStudentNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.txtClass.Text = dr.Cells[2].Value.ToString();
                frm.txtAcademic.Text = dr.Cells[3].Value.ToString();
                frm.txtTerm.Text = dr.Cells[4].Value.ToString();
                frm.txtDate.Text = dr.Cells[5].Value.ToString();
                frm.txtEnglish.Text = dr.Cells[6].Value.ToString();
                frm.txtMaths.Text = dr.Cells[7].Value.ToString();
                frm.txtRme.Text = dr.Cells[8].Value.ToString();
                frm.txtScience.Text = dr.Cells[9].Value.ToString();
                frm.txtFrench.Text = dr.Cells[10].Value.ToString();
                frm.txtTwi.Text = dr.Cells[11].Value.ToString();
                frm.txtIct.Text = dr.Cells[12].Value.ToString();
                frm.txtSocial.Text = dr.Cells[13].Value.ToString();
                frm.txtBdt.Text = dr.Cells[14].Value.ToString();
                frm.txtTotalMarks.Text = dr.Cells[15].Value.ToString();
                frm.btnGetCA.PerformClick();
                frm.btnCal.PerformClick();
                dtSID.Refresh();
                frm.btnSave.Enabled = false;
                frm.btnUpdate_record.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtDate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dtDate.SelectedRows[0];
                this.Show();
                AddMarks frm = new AddMarks();
                frm.Show();
                frm.txtStudentNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.txtClass.Text = dr.Cells[2].Value.ToString();
                frm.txtAcademic.Text = dr.Cells[3].Value.ToString();
                frm.txtTerm.Text = dr.Cells[4].Value.ToString();
                frm.txtDate.Text = dr.Cells[5].Value.ToString();
                frm.txtEnglish.Text = dr.Cells[6].Value.ToString();
                frm.txtMaths.Text = dr.Cells[7].Value.ToString();
                frm.txtRme.Text = dr.Cells[8].Value.ToString();
                frm.txtScience.Text = dr.Cells[9].Value.ToString();
                frm.txtFrench.Text = dr.Cells[10].Value.ToString();
                frm.txtTwi.Text = dr.Cells[11].Value.ToString();
                frm.txtIct.Text = dr.Cells[12].Value.ToString();
                frm.txtSocial.Text = dr.Cells[13].Value.ToString();
                frm.txtBdt.Text = dr.Cells[14].Value.ToString();
                frm.txtTotalMarks.Text = dr.Cells[15].Value.ToString();
                frm.btnGetCA.PerformClick();
                frm.btnCal.PerformClick();
                dtDate.Refresh();
                frm.btnSave.Enabled = false;
                frm.btnUpdate_record.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Show();
                AddMarks frm = new AddMarks();
                frm.Show();
                frm.txtStudentNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.txtClass.Text = dr.Cells[2].Value.ToString();
                frm.txtAcademic.Text = dr.Cells[3].Value.ToString();
                frm.txtTerm.Text = dr.Cells[4].Value.ToString();
                frm.txtDate.Text = dr.Cells[5].Value.ToString();
                frm.txtEnglish.Text = dr.Cells[6].Value.ToString();
                frm.txtMaths.Text = dr.Cells[7].Value.ToString();
                frm.txtRme.Text = dr.Cells[8].Value.ToString();
                frm.txtScience.Text = dr.Cells[9].Value.ToString();
                frm.txtFrench.Text = dr.Cells[10].Value.ToString();
                frm.txtTwi.Text = dr.Cells[11].Value.ToString();
                frm.txtIct.Text = dr.Cells[12].Value.ToString();
                frm.txtSocial.Text = dr.Cells[13].Value.ToString();
                frm.txtBdt.Text = dr.Cells[14].Value.ToString();
                frm.txtTotalMarks.Text = dr.Cells[15].Value.ToString();
                frm.btnGetCA.PerformClick();
                frm.btnCal.PerformClick();
                dataGridView1.Refresh();
                frm.btnSave.Enabled = false;
                frm.btnUpdate_record.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            order();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            orderDate();
        }
        private void button8_Click(object sender, EventArgs e)
        {
                maxMarksDate();
                maxMarksForm();
                maxMarksTerm();     
                EntryDate();         
        }
        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView2.SelectedRows[0];
                this.Show();
                AddMarks frm = new AddMarks();
                frm.Show();
                frm.txtStudentNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.txtClass.Text = dr.Cells[2].Value.ToString();
                frm.txtAcademic.Text = dr.Cells[3].Value.ToString();
                frm.txtTerm.Text = dr.Cells[4].Value.ToString();
                frm.txtDate.Text = dr.Cells[5].Value.ToString();
                frm.txtEnglish.Text = dr.Cells[6].Value.ToString();
                frm.txtMaths.Text = dr.Cells[7].Value.ToString();
                frm.txtRme.Text = dr.Cells[8].Value.ToString();
                frm.txtScience.Text = dr.Cells[9].Value.ToString();
                frm.txtFrench.Text = dr.Cells[10].Value.ToString();
                frm.txtTwi.Text = dr.Cells[11].Value.ToString();
                frm.txtIct.Text = dr.Cells[12].Value.ToString();
                frm.txtSocial.Text = dr.Cells[13].Value.ToString();
                frm.txtBdt.Text = dr.Cells[14].Value.ToString();
                frm.txtTotalMarks.Text = dr.Cells[15].Value.ToString();
                frm.btnGetCA.PerformClick();
                frm.btnCal.PerformClick();
                dataGridView2.Refresh();

                frm.btnSave.Enabled = false;
                frm.btnUpdate_record.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // Open dialog 
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel Fille";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel File(2010)|*.xls |Excel Files(2016)| *.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //Excel View Code
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 15;
                for (int i = 1; i < dtSN.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dtSN.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < dtSN.Rows.Count; i++)
                {
                    for (int j = 0; j < dtSN.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtSN.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                MessageBox.Show("Successfully Saved", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExcelApp.Quit();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            // Open dialog 
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel Fille";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel File(2010)|*.xls |Excel Files(2016)| *.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //Excel View Code
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 15;
                for (int i = 1; i < dtDate.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dtDate.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < dtDate.Rows.Count; i++)
                {
                    for (int j = 0; j < dtDate.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtDate.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                MessageBox.Show("Successfully Saved", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExcelApp.Quit();
            }
        }
    }
}
