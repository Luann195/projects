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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace reportCard
{
    public partial class Student_Search : MetroForm
    {
        private MySqlDataReader rdr;
        public Student_Search()
        {
            InitializeComponent();

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
                String sql = "select distinct RTRIM(student_id ) from student";
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
                String sql = "select RTRIM(student_id),RTRIM(student_name),RTRIM(reg_date),RTRIM(add_class),RTRIM(res_info) from reportcard.student where student_name like '" + txtSName.Text + "%' order by student_name";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtSN.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtSN.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Student_Search_Load(object sender, EventArgs e)
        {
            GET();
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
                String sql = "select RTRIM(student_id),RTRIM(student_name),RTRIM(reg_date),RTRIM(add_class),RTRIM(res_info) from reportcard.student where student_id like '" + cmbStudent.Text + "%' order by student_id";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtSID.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtSID.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
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
                String sql = "select RTRIM(student_id),RTRIM(student_name),RTRIM(reg_date),RTRIM(add_class),RTRIM(res_info) from reportcard.student where reg_date like '" + txtDate.Text + "%' order by reg_date";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dtDate.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dtDate.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dtDate.Rows.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            dtSID.Rows.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dtSN.Rows.Clear();
        }
        private void dtSN_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dtSN.SelectedRows[0];
                this.Show();
                AddStudents frm = new AddStudents();
                frm.Show();
                frm.txtAdmissionNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.dtpAdmissionDate.Text = dr.Cells[2].Value.ToString();
                frm.cmbClass.Text = dr.Cells[3].Value.ToString();
                frm.cmbRI.Text = dr.Cells[4].Value.ToString();
                dtSN.Refresh();
                frm.btnSave.Enabled = false;
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
                AddStudents frm = new AddStudents();
                frm.Show();
                frm.txtAdmissionNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.dtpAdmissionDate.Text = dr.Cells[2].Value.ToString();
                frm.cmbClass.Text = dr.Cells[3].Value.ToString();
                frm.cmbRI.Text = dr.Cells[4].Value.ToString();
                dtSN.Refresh();
                frm.btnSave.Enabled = false;
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
                AddStudents frm = new AddStudents();
                frm.Show();
                frm.txtAdmissionNo.Text = dr.Cells[0].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[1].Value.ToString();
                frm.dtpAdmissionDate.Text = dr.Cells[2].Value.ToString();
                frm.cmbClass.Text = dr.Cells[3].Value.ToString();
                frm.cmbRI.Text = dr.Cells[4].Value.ToString();
                dtSN.Refresh();

                frm.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
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
                for (int i = 1; i < dtSID.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dtSID.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < dtSID.Rows.Count; i++)
                {
                    for (int j = 0; j < dtSID.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtSID.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                MessageBox.Show("Successfully Saved", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExcelApp.Quit();
            }
        }
        private void button7_Click(object sender, EventArgs e)
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
                String sql = "select RTRIM(student_id),RTRIM(student_name),RTRIM(reg_date),RTRIM(add_class),RTRIM(res_info) from reportcard.student where add_class like '" + cmbAC.Text + "%' order by add_class";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                rdr = newuser.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
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
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                MessageBox.Show("Successfully Saved", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExcelApp.Quit();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
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