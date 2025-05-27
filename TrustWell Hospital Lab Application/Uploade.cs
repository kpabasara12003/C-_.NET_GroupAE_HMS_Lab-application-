using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace TrustWell_Hospital_Lab_Application
{
    public partial class Uploade: UserControl
    {
        private Home amainForm;
        private int patientId;
        private string patientEmail;
        private string TestName;
        private int Labid;
        public Uploade(int patientid, Home mainForm, string Email, string Testname, int labid)
        {
            InitializeComponent();
            patientId = patientid;
            amainForm = mainForm;
            patientEmail = Email;
            TestName = Testname;
            Labid = labid;
            panelone.Visible = false;
            paneltwo.Visible = false;

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            amainForm.LoadUserControl(new page1(amainForm));
        }

        private void Uploade_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Type From Testtypes WHERE TestName = @TestName";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@TestName", TestName)
                };

                DataTable dt = Database.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    string testType = dt.Rows[0]["Type"].ToString();

                    if (testType == "1value")
                    {
                        paneltwo.Visible = true;
                        panelone.Visible = true;
                    }
                    else
                    {
                        paneltwo.Visible = false;
                        panelone.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Test tpye not found for the second test.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error fetching test type: "+ ex.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(openFileDialog.FileName);

                doctxt.Text = $"{filename}";
            }

        }

        private void doctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void subbut_Click(object sender, EventArgs e)
        {
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            Random random = new Random();
            int randomNumber = random.Next(10000, 900000);
            string testid = $"{randomNumber + UserSession.StaffId + patientId}";
            try
            {
                string query = "SELECT Type, TestID FROM Testtypes WHERE TestName = @TestName";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@TestName", TestName)
                };

                DataTable dt = Database.ExecuteQuery(query, parameters);
               
                if (dt.Rows.Count > 0)
                {
                    string testType = dt.Rows[0]["Type"].ToString();
                    string TestTypeID = dt.Rows[0]["TestID"].ToString();

                    if (testType == "1value")
                    {
                        string resultval = valbut.Text.Trim();

                        if (string.IsNullOrWhiteSpace(resultval))
                        {
                            MessageBox.Show("Please enter a valid result");
                            return;
                        }


                        try
                        {
                            string Filename = doctxt.Text.Trim();
                            string insertQueryVal = @"INSERT INTO TestReports (PatientID, TestType, TestID, value, Date) VALUES (@PatientID, @TestType, @TestID, @Value, @Date)";

                            if (string.IsNullOrWhiteSpace(Filename))
                            {
                                MessageBox.Show("Please select a file to upload.");
                                return;
                            }

                            string updateQueryRepo = @"UPDATE LabTests SET Report = @Report WHERE LabTID = @LabID";

                            MySqlParameter[] reportparam = new MySqlParameter[]
                            {
                            new MySqlParameter("@Report", Filename),
                            new MySqlParameter("@LabID", Labid)
                            };

                            Database.ExecuteNonQuery(updateQueryRepo, reportparam);
                            MySqlParameter[] paramVal = new MySqlParameter[]
                            {
                                new MySqlParameter("@PatientID", patientId),
                                new MySqlParameter("@TestType", TestTypeID),
                                new MySqlParameter("@TestID", testid),
                                new MySqlParameter("@Value", resultval),
                                new MySqlParameter("@Date", formattedDate)
                            };

                            Console.WriteLine("Running TestReports insert...");
                            Database.ExecuteNonQuery(insertQueryVal, paramVal);
                            Console.WriteLine("Insert complete.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Insert failed: " + ex.Message);
                        }

                    }
                    else
                    {
                        string filename = doctxt.Text.Trim();

                        if (string.IsNullOrWhiteSpace(filename))
                        {
                            MessageBox.Show("Please select a file to upload.");
                            return;
                        }

                        string updateQueryRepo = @"UPDATE LabTests SET Report = @Report WHERE LabTID = @LabID";

                        MySqlParameter[] reportparam = new MySqlParameter[]
                        {
                            new MySqlParameter("@Report", filename),
                            new MySqlParameter("@LabID", Labid)
                        };

                        Database.ExecuteNonQuery(updateQueryRepo, reportparam);
                    }

                    string updateStatquer = @"UPDATE LabTests SET Status = 'Done', StaffID = @Staffid, TestId = @Testid, TestDate = @Testdate WHERE LabTID = @LabID";

                    MySqlParameter[] statparam = new MySqlParameter[]
                    {
                        new MySqlParameter("@LabID", Labid),
                        new MySqlParameter("@Staffid", UserSession.StaffId),
                        new MySqlParameter("@Testdate", formattedDate),
                        new MySqlParameter("@Testid", testid)
                    };

                    Database.ExecuteNonQuery(updateStatquer, statparam);
                    MessageBox.Show("Test Result Submitted Successfully.");
                    amainForm.LoadUserControl(new page1(amainForm));
                }
                else
                {
                    MessageBox.Show("Test Type not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Submitting test result : " + ex.Message);
            }
        }// here create the funtions use patientid logics here
    }
}
