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
    public partial class AddMarks : MetroForm
    {
        private MySqlDataReader rdr;
        private string sql;
        public AddMarks()
        {
            InitializeComponent();
        }
        private void reset()
        {
            txtStudentNo.Text = "";
            txtStudentName.Text = "";
            txtClass.Text = "";
            txtAcademic.Text = "";
            txtTerm.Text = "";
            txtDate.Text = "";
            txtEnglish.Text = "";
            txtMaths.Text = "";
            txtRme.Text = "";
            txtScience.Text = "";
            txtFrench.Text = "";
            txtTwi.Text = "";
            txtIct.Text = "";
            txtSocial.Text = "";
            txtBdt.Text = "";
            txtTotalMarks.Text = "";
            txtEM.Text = "";
            txtMM.Text = "";
            txtRM.Text = "";
            txtGSM.Text = "";
            txtFM.Text = "";
            txtTM.Text = "";
            txtIM.Text = "";
            txtSM.Text = "";
            txtBM.Text = "";
            txtCAE.Text = "";
            txtCAM.Text = "";
            txtCAR.Text = "";
            txtCAGS.Text = "";
            txtCAF.Text = "";
            txtCAT.Text = "";
            txtCAI.Text = "";
            txtCAS.Text = "";
            txtCAB.Text = "";
        }
        private void getCA()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;


                cmd = connection.CreateCommand();

                cmd.CommandText = "select english_ca,maths_ca,rme_ca,science_ca,french_ca,twi_ca,ict_ca,social_ca,bdt_ca from ca where entry_date= '"+txtDate.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtCAE.Text = rdr.GetString(0).Trim();
                    txtCAM.Text = rdr.GetString(1).Trim();
                    txtCAR.Text = rdr.GetString(2).Trim();
                    txtCAGS.Text = rdr.GetString(3).Trim();
                    txtCAF.Text = rdr.GetString(4).Trim();
                    txtCAT.Text = rdr.GetString(5).Trim();
                    txtCAI.Text = rdr.GetString(6).Trim();
                    txtCAS.Text = rdr.GetString(7).Trim();
                    txtCAB.Text = rdr.GetString(8).Trim();
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getMarks()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();

                cmd.CommandText = "select english_m,maths_m,rme_m,science_m,french_m,twi_m,ict_m,social_m,bdt_m from exams_marks where entry_date= '" +txtDate.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtEM.Text = rdr.GetString(0).Trim();
                    txtMM.Text = rdr.GetString(1).Trim();
                    txtRM.Text = rdr.GetString(2).Trim();
                    txtGSM.Text = rdr.GetString(3).Trim();
                    txtFM.Text = rdr.GetString(4).Trim();
                    txtTM.Text = rdr.GetString(5).Trim();
                    txtIM.Text = rdr.GetString(6).Trim();
                    txtSM.Text = rdr.GetString(7).Trim();
                    txtBM.Text = rdr.GetString(8).Trim();
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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
                String sql = "select distinct RTRIM(student_id) from student";
                MySqlCommand newuser = new MySqlCommand(sql, connection);
                newuser.Connection = connection;

                rdr = newuser.ExecuteReader();
                while (rdr.Read())
                {
                    txtStudentNo.Items.Add(rdr[0]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resi()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select distinct RTRIM(res_info) from student where student_id='" +txtID.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lRES.Text = rdr.GetString(0).Trim();
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void res()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select distinct RTRIM(res_info) from student where student_id='" +txtStudentNo.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lRES.Text = rdr.GetString(0).Trim();

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveQuery()
        {
            //String Definations
            string student_id = txtStudentNo.Text;
            string student_name = txtStudentName.Text;
            string class_form = txtClass.Text;
            string year = txtAcademic.Text;
            string term = txtTerm.Text;
            string entry_date = txtDate.Text;
            string english_em = txtEnglish.Text;
            string maths_em = txtMaths.Text;
            string rme_em = txtRme.Text;
            string science_em = txtScience.Text;
            string french_em = txtFrench.Text;
            string twi_em = txtTwi.Text;
            string ict_em = txtIct.Text;
            string social_em = txtSocial.Text;
            string bdt_em = txtBdt.Text;
            string total_marks = txtTotalMarks.Text;
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
                string q = "insert into reportcard.marks(student_id, student_name, class_form, year, term, entry_date, english_em, maths_em, rme_em, science_em, french_em, twi_em, ict_em, social_em, bdt_em, total_marks) VALUES (@student_id, @student_name, @class_form, @year, @term, @entry_date, @english_em, @maths_em, @rme_em, @science_em, @french_em, @twi_em, @ict_em, @social_em, @bdt_em, @total_marks)";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                //Adding String Defination to databse table base on textbox values
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@student_name", student_name);
                newuser.Parameters.AddWithValue("@class_form", class_form);
                newuser.Parameters.AddWithValue("@year", year);
                newuser.Parameters.AddWithValue("@term", term);
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_em", english_em);
                newuser.Parameters.AddWithValue("@maths_em", maths_em);
                newuser.Parameters.AddWithValue("@rme_em", rme_em);
                newuser.Parameters.AddWithValue("@science_em", science_em);
                newuser.Parameters.AddWithValue("@french_em", french_em);
                newuser.Parameters.AddWithValue("@twi_em", twi_em);
                newuser.Parameters.AddWithValue("@ict_em", ict_em);
                newuser.Parameters.AddWithValue("@social_em", social_em);
                newuser.Parameters.AddWithValue("@bdt_em", bdt_em);
                newuser.Parameters.AddWithValue("@total_marks", total_marks);

                int x = Int32.Parse(txtEnglish.Text);
                int y = Int32.Parse(txtMaths.Text);
                int z = Int32.Parse(txtRme.Text);
                int s = Int32.Parse(txtScience.Text);
                int f = Int32.Parse(txtFrench.Text);
                int t = Int32.Parse(txtTwi.Text);
                int i = Int32.Parse(txtIct.Text);
                int ss = Int32.Parse(txtSocial.Text);
                int b = Int32.Parse(txtBdt.Text);
                int tm = Int32.Parse(txtTotalMarks.Text);

                if (x <= 100 && y <= 100 && z <= 100 && s <= 100 && s <= 100 && f <= 100 && t <= 100 && i <= 100 && ss <= 100 && b <= 100 && tm <= 900)
                {
                    newuser.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved", "Mark Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Exam Mark is Invalid, Can not be more than 100%");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveQueryCa()
        {
            //String Definations
            string student_id = txtStudentNo.Text;
            string entry_date = txtDate.Text;
            string english_ca = txtCAE.Text;
            string maths_ca = txtCAM.Text;
            string rme_ca = txtCAR.Text;
            string science_ca = txtCAGS.Text;
            string french_ca = txtCAF.Text;
            string twi_ca = txtCAT.Text;
            string ict_ca = txtCAI.Text;
            string social_ca = txtCAS.Text;
            string bdt_ca = txtCAB.Text;
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
                string q = "insert into reportcard.ca(student_id, entry_date, english_ca, maths_ca, rme_ca, science_ca, french_ca, twi_ca, ict_ca, social_ca, bdt_ca) VALUES (@student_id, @entry_date, @english_ca, @maths_ca, @rme_ca, @science_ca, @french_ca, @twi_ca, @ict_ca, @social_ca, @bdt_ca)";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                //Adding String Defination to databse table base on textbox values
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_ca", english_ca);
                newuser.Parameters.AddWithValue("@maths_ca", maths_ca);
                newuser.Parameters.AddWithValue("@rme_ca", rme_ca);
                newuser.Parameters.AddWithValue("@science_ca", science_ca);
                newuser.Parameters.AddWithValue("@french_ca", french_ca);
                newuser.Parameters.AddWithValue("@twi_ca", twi_ca);
                newuser.Parameters.AddWithValue("@ict_ca", ict_ca);
                newuser.Parameters.AddWithValue("@social_ca", social_ca);
                newuser.Parameters.AddWithValue("@bdt_ca", bdt_ca);

                int xca = Int32.Parse(txtCAE.Text);
                int yca = Int32.Parse(txtCAM.Text);
                int zca = Int32.Parse(txtCAR.Text);
                int sca = Int32.Parse(txtCAGS.Text);
                int fca = Int32.Parse(txtCAF.Text);
                int tca = Int32.Parse(txtCAT.Text);
                int ica = Int32.Parse(txtCAI.Text);
                int ssca = Int32.Parse(txtCAS.Text);
                int bca = Int32.Parse(txtCAB.Text);

                if (xca <=30 && yca <=30 && zca <=30 && sca <=30 && sca <=30 && fca <=30 && tca <=30 && ica <=30 && ssca <=30 && bca <=30 )
                {
                    newuser.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved", "CA Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Class Marks is Invalid, Can not be more than 30%");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveQueryExams()
        {
            //String Definations
            string student_id = txtStudentNo.Text;
            string entry_date = txtDate.Text;
            string english_m = txtEM.Text;
            string maths_m = txtMM.Text;
            string rme_m = txtRM.Text;
            string science_m = txtGSM.Text;
            string french_m = txtFM.Text;
            string twi_m = txtTM.Text;
            string ict_m = txtIM.Text;
            string social_m = txtSM.Text;
            string bdt_m = txtBM.Text;

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
                string q = "insert into reportcard.exams_marks(student_id, entry_date, english_m, maths_m, rme_m, science_m, french_m, twi_m, ict_m, social_m, bdt_m) VALUES (@student_id, @entry_date, @english_m, @maths_m, @rme_m, @science_m, @french_m, @twi_m, @ict_m, @social_m, @bdt_m)";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                //Adding String Defination to databse table base on textbox values
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_m", english_m);
                newuser.Parameters.AddWithValue("@maths_m", maths_m);
                newuser.Parameters.AddWithValue("@rme_m", rme_m);
                newuser.Parameters.AddWithValue("@science_m", science_m);
                newuser.Parameters.AddWithValue("@french_m", french_m);
                newuser.Parameters.AddWithValue("@twi_m", twi_m);
                newuser.Parameters.AddWithValue("@ict_m", ict_m);
                newuser.Parameters.AddWithValue("@social_m", social_m);
                newuser.Parameters.AddWithValue("@bdt_m", bdt_m);

                int xM = Int32.Parse(txtEM.Text);
                int yM = Int32.Parse(txtMM.Text);
                int zM = Int32.Parse(txtRM.Text);
                int sM = Int32.Parse(txtGSM.Text);
                int fM = Int32.Parse(txtFM.Text);
                int tM = Int32.Parse(txtTM.Text);
                int iM = Int32.Parse(txtIM.Text);
                int ssM = Int32.Parse(txtSM.Text);
                int bM = Int32.Parse(txtBM.Text);

                if (xM<=70 && yM<=70 && zM<=70 && sM<=70 && sM<=70 && fM<=70 && tM<=70 && iM<=70 && ssM<=70 && bM<=70)
                {
                    newuser.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved", "Exams Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Exams Marks is Invalid, Can not be more than 70%");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveQuery();
            saveQueryCa();
            saveQueryExams();
        }
        private void cal()
        {
            float e , em = 0;
            float mc, mm = 0;
            float r, rm = 0;
            float si, sim = 0;
            float fc, fcm = 0;
            float tc, tcm = 0;
            float ic, icm = 0;
            float ssc, sscm = 0;
            float bc, bcm = 0;

            float.TryParse(txtCAE.Text, out e);
            float.TryParse(txtEM.Text, out em);
            float CAE = ((e + em));
            txtEnglish.Text = CAE.ToString();

            float.TryParse(txtCAM.Text, out mc);
            float.TryParse(txtMM.Text, out mm);
            float MCAM = ((mc + mm));
            txtMaths.Text = MCAM.ToString();

            float.TryParse(txtCAR.Text, out r);
            float.TryParse(txtRM.Text, out rm);
            float RCAM = ((r + rm));
            txtRme.Text = RCAM.ToString();

            float.TryParse(txtCAGS.Text, out si);
            float.TryParse(txtGSM.Text, out sim);
            float SI = ((si + sim));
            txtScience.Text = SI.ToString();

            float.TryParse(txtCAF.Text, out fc);
            float.TryParse(txtFM.Text, out fcm);
            float FCM = ((fc + fcm));
            txtFrench.Text = FCM.ToString();

            float.TryParse(txtCAT.Text, out tc);
            float.TryParse(txtTM.Text, out tcm);
            float TM = ((tc + tcm));
            txtTwi.Text = TM.ToString();

            float.TryParse(txtCAI.Text, out ic);
            float.TryParse(txtIM.Text, out icm);
            float ITM = ((ic + icm));
            txtIct.Text = ITM.ToString();

            float.TryParse(txtCAS.Text, out ssc);
            float.TryParse(txtSM.Text, out sscm);
            float SSCM = ((ssc + sscm));
            txtSocial.Text = SSCM.ToString();

            float.TryParse(txtCAB.Text, out bc);
            float.TryParse(txtBM.Text, out bcm);
            float BCM = ((bc + bcm));
            txtBdt.Text = BCM.ToString();

            float val1 = 0;
            float val2 = 0;
            float val3 = 0;
            float val4 = 0;
            float val5 = 0;
            float val6 = 0;
            float val7 = 0;
            float val8 = 0;
            float val9 = 0;

            float.TryParse(txtEnglish.Text, out val1);
            float.TryParse(txtMaths.Text, out val2);
            float.TryParse(txtRme.Text, out val3);
            float.TryParse(txtScience.Text, out val4);
            float.TryParse(txtFrench.Text, out val5);
            float.TryParse(txtTwi.Text, out val6);
            float.TryParse(txtIct.Text, out val7);
            float.TryParse(txtSocial.Text, out val8);
            float.TryParse(txtBdt.Text, out val9);

            int x = Int32.Parse(txtEnglish.Text);
            int y = Int32.Parse(txtMaths.Text);
            int z = Int32.Parse(txtRme.Text);
            int s = Int32.Parse(txtScience.Text);
            int f = Int32.Parse(txtFrench.Text);
            int t = Int32.Parse(txtTwi.Text);
            int i = Int32.Parse(txtIct.Text);
            int ss = Int32.Parse(txtSocial.Text);
            int b = Int32.Parse(txtBdt.Text);

            if (x<=100 && y<=100 && z<=100 && s<=100 && s<=100 && f<=100 && t<=100 && i<=100 && ss<=100 && b<=100)
            {

                float I = ((val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9));
                txtTotalMarks.Text = I.ToString();
            }

            else
            {
                MessageBox.Show("Exam Mark is Invalid, Can not be more than 100%");
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            cal();
            grade();
        }
        private void AddMarks_Load(object sender, EventArgs e)
        {
            GET();   
        }
        private void txtStudentNo_SelectedIndexChanged(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select student_name from student where student_id='" + txtStudentNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtStudentName.Text = rdr.GetString(0).Trim();
                    res();

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtID_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select student_name from student where student_id='" + txtStudentNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtStudentName.Text = rdr.GetString(0).Trim();

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getname()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select student_id from student where student_id='" + txtID.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtStudentNo.Text = rdr.GetString(0).Trim();
                    resi();
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void idgetput()
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
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Connection = connection;
                cmd = connection.CreateCommand();
                cmd.CommandText = "select student_name from student where student_id='" + txtID.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtStudentName.Text = rdr.GetString(0).Trim();
                    resi();
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            idgetput();
            getname();
        }
        private void grade()
        {
            int x1, y1, z1, s1, f1, t1, i1, ss1, b1;
            
            x1 = int.Parse(txtEnglish.Text);
            y1 = int.Parse(txtMaths.Text);
            z1 = int.Parse(txtRme.Text);
            s1 = int.Parse(txtScience.Text);
            f1 = int.Parse(txtFrench.Text);
            t1 = int.Parse(txtTwi.Text);
            i1 = int.Parse(txtIct.Text);
            ss1 = int.Parse(txtSocial.Text);
            b1 = int.Parse(txtBdt.Text);

            le.Text = Convert.ToString(Grade(x1));
            lm.Text = Convert.ToString(Grade(y1));
            lr.Text = Convert.ToString(Grade(z1));
            lg.Text = Convert.ToString(Grade(s1));
            lf.Text = Convert.ToString(Grade(f1));
            lt.Text = Convert.ToString(Grade(t1));
            li.Text = Convert.ToString(Grade(i1));
            ls.Text = Convert.ToString(Grade(ss1));
            lb.Text = Convert.ToString(Grade(b1));

            lER.Text = Convert.ToString(Remarks(x1));
            lMR.Text = Convert.ToString(Remarks(y1));
            lRR.Text = Convert.ToString(Remarks(z1));
            lSR.Text = Convert.ToString(Remarks(s1));
            lFR.Text = Convert.ToString(Remarks(f1));
            lTR.Text = Convert.ToString(Remarks(t1));
            lICTR.Text = Convert.ToString(Remarks(i1));
            lSSR.Text = Convert.ToString(Remarks(ss1));
            LBR.Text = Convert.ToString(Remarks(b1));

        }
        string Grade(int mark)
        {
            string g = " ";
            if (mark <=39)
            {
                g = "9";
            }
            else if (mark >=40 && mark <=44)
            {
                g = "8";
            }
            else if (mark >=45 && mark <=49)
            {
                g = "7";
            }

            else if (mark >=50 && mark <=54)
            {
                g = "6";
            }
            else if (mark >=55 && mark <= 59)
            {
                g = "5";
            }
            else if (mark >=60 && mark <=64)
            {
                g = "4";
            }
            else if (mark >=65 && mark <=69)
            {
                g = "3";
            }
            else if (mark >=70 && mark <=79)
            {
                g = "2";
            }
            else if (mark >= 80 && mark <=100)
            {
                g = "1";
            }
            return g;
        }
        string Remarks(int mark)
        {
            string r = " ";
            if ( mark <=39)
            {
                r = "Fail";
            }
            else if(mark >=40 && mark <=44)
            {
                r = "Pass"; 
            }
            else if (mark >=45 &&  mark <=49)
            {
                r = "Pass";
            }

            else if (mark >=50 && mark <=54)
            {
                r = "Credit";
            }
            else if (mark >=55 && mark <=59)
            {
                r = "Credit";
            }
            else if (mark >=60 && mark <=64)
            {
                r = "Credit";
            }
            else if (mark >=65 && mark <=69)
            {
                r = "Good";
            }
            else if (mark >=70 && mark <=79)
            {
                r = "Very Good";
            }
            else if (mark >=80 && mark <=100)
            {
                r = "Excellent";
            }
            return r;
        }
        private void updateTotalMarks()
        {
            //String Definations
            string student_id = txtStudentNo.Text;
            string student_name = txtStudentName.Text;
            string class_form = txtClass.Text;
            string year = txtAcademic.Text;
            string term = txtTerm.Text;
            string entry_date = txtDate.Text;
            string english_em = txtEnglish.Text;
            string maths_em = txtMaths.Text;
            string rme_em = txtRme.Text;
            string science_em = txtScience.Text;
            string french_em = txtFrench.Text;
            string twi_em = txtTwi.Text;
            string ict_em = txtIct.Text;
            string social_em = txtSocial.Text;
            string bdt_em = txtBdt.Text;
            string total_marks = txtTotalMarks.Text;

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
                string q = "update reportcard.marks set student_id=@student_id, student_name=@student_name, class_form=@class_form, year=@year, term=@term, entry_date=@entry_date, english_em=@english_em, maths_em=@maths_em, rme_em=@rme_em, science_em=@science_em, french_em=@french_em, twi_em=@twi_em, ict_em=@ict_em, social_em=@social_em, bdt_em=@bdt_em, total_marks=@total_marks where entry_date=@entry_date";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                newuser.Parameters.AddWithValue("@student_id", student_id);
                newuser.Parameters.AddWithValue("@student_name", student_name);
                newuser.Parameters.AddWithValue("@class_form", class_form);
                newuser.Parameters.AddWithValue("@year", year);
                newuser.Parameters.AddWithValue("@term", term);
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_em", english_em);
                newuser.Parameters.AddWithValue("@maths_em", maths_em);
                newuser.Parameters.AddWithValue("@rme_em", rme_em);
                newuser.Parameters.AddWithValue("@science_em", science_em);
                newuser.Parameters.AddWithValue("@french_em", french_em);
                newuser.Parameters.AddWithValue("@twi_em", twi_em);
                newuser.Parameters.AddWithValue("@ict_em", ict_em);
                newuser.Parameters.AddWithValue("@social_em", social_em);
                newuser.Parameters.AddWithValue("@bdt_em", bdt_em);
                newuser.Parameters.AddWithValue("@total_marks", total_marks);
                newuser.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Student Total Marks(100%)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateCA()
        {
            //String Definations
            string entry_date = txtDate.Text;
            string english_ca = txtCAE.Text;
            string maths_ca = txtCAM.Text;
            string rme_ca = txtCAR.Text;
            string science_ca = txtCAGS.Text;
            string french_ca = txtCAF.Text;
            string twi_ca = txtCAT.Text;
            string ict_ca = txtCAI.Text;
            string social_ca = txtCAS.Text;
            string bdt_ca = txtCAB.Text;

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
                string q = "update reportcard.ca set entry_date=@entry_date, english_ca=@english_ca, maths_ca=@maths_ca, rme_ca=@rme_ca, science_ca=@science_ca, french_ca=@french_ca, twi_ca=@twi_ca, ict_ca=@ict_ca, social_ca=@social_ca, bdt_ca=@bdt_ca where entry_date=@entry_date";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_ca", english_ca);
                newuser.Parameters.AddWithValue("@maths_ca", maths_ca);
                newuser.Parameters.AddWithValue("@rme_ca", rme_ca);
                newuser.Parameters.AddWithValue("@science_ca", science_ca);
                newuser.Parameters.AddWithValue("@french_ca", french_ca);
                newuser.Parameters.AddWithValue("@twi_ca", twi_ca);
                newuser.Parameters.AddWithValue("@ict_ca", ict_ca);
                newuser.Parameters.AddWithValue("@social_ca", social_ca);
                newuser.Parameters.AddWithValue("@bdt_ca", bdt_ca);
                newuser.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Student Class Marks(30%)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateExamsMarks()
        {
            //String Definations
            string entry_date = txtDate.Text;
            string english_m = txtEM.Text;
            string maths_m = txtMM.Text;
            string rme_m = txtRM.Text;
            string science_m = txtGSM.Text;
            string french_m = txtFM.Text;
            string twi_m = txtTM.Text;
            string ict_m = txtIM.Text;
            string social_m = txtSM.Text;
            string bdt_m = txtBM.Text;

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
                string q = "update reportcard.exams_marks set entry_date=@entry_date, english_m=@english_m, maths_m=@maths_m, rme_m=@rme_m, science_m=@science_m, french_m=@french_m, twi_m=@twi_m, ict_m=@ict_m, social_m=@social_m, bdt_m=@bdt_m where entry_date=@entry_date";
                MySqlCommand newuser = new MySqlCommand(q, connection);
                newuser.CommandText = q;
                newuser.Parameters.AddWithValue("@entry_date", entry_date);
                newuser.Parameters.AddWithValue("@english_m", english_m);
                newuser.Parameters.AddWithValue("@maths_m", maths_m);
                newuser.Parameters.AddWithValue("@rme_m", rme_m);
                newuser.Parameters.AddWithValue("@science_m", science_m);
                newuser.Parameters.AddWithValue("@french_m", french_m);
                newuser.Parameters.AddWithValue("@twi_m", twi_m);
                newuser.Parameters.AddWithValue("@ict_m", ict_m);
                newuser.Parameters.AddWithValue("@social_m", social_m);
                newuser.Parameters.AddWithValue("@bdt_m", bdt_m);
                newuser.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Student Exams Marks(70%)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            updateTotalMarks();
            updateCA();
            updateExamsMarks();
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students_Results_Search s = new Students_Results_Search();
            s.Show();
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Properties.Resources.logo;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            e.Graphics.DrawString("Student Name: " + txtStudentName.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("Date: " + txtDate.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Student ID: " + txtStudentNo.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 195));
            e.Graphics.DrawString("Term: " + txtTerm.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 225));
            e.Graphics.DrawString("Position:_____", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Form: " + txtClass.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawString("Next Term Begins:______________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, 250));
            e.Graphics.DrawString(DashLable.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 270));

            //table
            e.Graphics.DrawString("Subjects", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("CA 30%", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120, 280));
            e.Graphics.DrawString("Exams Marks 70%", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 280));
            e.Graphics.DrawString("Total Marks 100%", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(360, 280));
            e.Graphics.DrawString("Grade", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 280));
            e.Graphics.DrawString("Remarks", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 280));
            e.Graphics.DrawString(DashLable.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 300));

            //Subjects
            e.Graphics.DrawString("English", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 315));
            e.Graphics.DrawString("Maths", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));
            e.Graphics.DrawString("R.M.E", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 370));
            e.Graphics.DrawString("Science" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("French", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Twi ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));
            e.Graphics.DrawString("I.C.T", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 490));
            e.Graphics.DrawString("Social ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 520));
            e.Graphics.DrawString("B.D.T ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 550));
            e.Graphics.DrawString("Total Exams Marks", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 620));
            e.Graphics.DrawString("Residential Info:" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 670));
            e.Graphics.DrawString("Attendance Time Present_____________________________Out of_____________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 710));
            e.Graphics.DrawString("Promoted To___________ To be Repeated in Form____________ Go away from school_____________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 760));
            e.Graphics.DrawString("Form Teacher's Remarks_______________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 810));
            e.Graphics.DrawString("Headmaster's Remarks_________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 850));
            e.Graphics.DrawString("Payment must be made on or before the reopening date.Fialure to pay will affect the student in School.", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 900));
            e.Graphics.DrawString("If reportcard is not stamped then is not an original copy form the school unless it is sent electronically!", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 925));
            e.Graphics.DrawString("Form Master's Signature________________________Manager's Signature_______________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 980));
            e.Graphics.DrawString(DashLable.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 590));

            //CA's(30%)
            e.Graphics.DrawString(txtCAE.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 315));
            e.Graphics.DrawString(txtCAM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 340));
            e.Graphics.DrawString(txtCAR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 370));
            e.Graphics.DrawString(txtCAGS.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 400));
            e.Graphics.DrawString(txtCAF.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 430));
            e.Graphics.DrawString(txtCAT.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 460));
            e.Graphics.DrawString(txtCAI.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 490));
            e.Graphics.DrawString(txtCAS.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 520));
            e.Graphics.DrawString(txtCAB.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(130, 550));

            //Exams Marks(70%) 
            e.Graphics.DrawString(txtEM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 315));
            e.Graphics.DrawString(txtMM .Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 340));
            e.Graphics.DrawString(txtRM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 370));
            e.Graphics.DrawString(txtGSM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 400));
            e.Graphics.DrawString(txtFM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 430));
            e.Graphics.DrawString(txtTM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 460));
            e.Graphics.DrawString(txtIM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 490));
            e.Graphics.DrawString(txtSM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 520));
            e.Graphics.DrawString(txtBM.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 550));

            //Total Exams Marks(100%)
            e.Graphics.DrawString(txtEnglish.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 315));
            e.Graphics.DrawString(txtMaths.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 340));
            e.Graphics.DrawString(txtRme.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 370));
            e.Graphics.DrawString(txtScience.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 400));
            e.Graphics.DrawString(txtFrench.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 430));
            e.Graphics.DrawString(txtTwi.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 460));
            e.Graphics.DrawString(txtIct.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 490));
            e.Graphics.DrawString(txtSocial.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 520));
            e.Graphics.DrawString(txtBdt.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 550));
            e.Graphics.DrawString(txtTotalMarks.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 620));
            e.Graphics.DrawString(lRES.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(160, 670));
            
            //grades
            e.Graphics.DrawString(le.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 315));
            e.Graphics.DrawString(lm.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 340));
            e.Graphics.DrawString(lr.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 370));
            e.Graphics.DrawString(lg.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 400));
            e.Graphics.DrawString(lf.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 430));
            e.Graphics.DrawString(lt.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 460));
            e.Graphics.DrawString(li.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 490));
            e.Graphics.DrawString(ls.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 520));
            e.Graphics.DrawString(lb.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, 550));

            //Remarks 
            e.Graphics.DrawString(lER.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 315));
            e.Graphics.DrawString(lMR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 340));
            e.Graphics.DrawString(lRR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 370));
            e.Graphics.DrawString(lSR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 400));
            e.Graphics.DrawString(lFR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 430));
            e.Graphics.DrawString(lTR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 460));
            e.Graphics.DrawString(lICTR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 490));
            e.Graphics.DrawString(lSSR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 520));
            e.Graphics.DrawString(LBR.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 550));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            getCA();
            getMarks();
        }
        private void AddMarks_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}