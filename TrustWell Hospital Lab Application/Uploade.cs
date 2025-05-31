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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net;

namespace TrustWell_Hospital_Lab_Application
{
    public partial class Uploade: UserControl
    {
        private Home amainForm;
        private int patientId;
        private string patientEmail;
        private string TestName;
        private int Labid;
        private string nameoftest;
        private string PatientName;
        public Uploade(int patientid, Home mainForm, string Email, string Testname, int labid, string pname)
        {
            InitializeComponent();
            patientId = patientid;
            amainForm = mainForm;
            patientEmail = Email;
            TestName = Testname;
            Labid = labid;
            nameoftest = Testname;
            PatientName = pname;
            panelone.Visible = false;
            paneltwo.Visible = false;
            

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            amainForm.LoadUserControl(new page1(amainForm));
        }

        private void Uploade_Load(object sender, EventArgs e)
        {
            label2.Text = $"{nameoftest} Test Lab Report Upload";
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

        private string uploadfilepath = "";

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if(openFiledialog.ShowDialog() == DialogResult.OK)
            {
                uploadfilepath = openFiledialog.FileName;
                doctxt.Text = Path.GetFileName(openFiledialog.FileName);
            }

        }

        private void doctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private async void subbut_Click(object sender, EventArgs e)
        {
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            string datekey = DateTime.Now.ToString("yyMM");
            Random random = new Random();
            int randomNumber = random.Next(10000, 99990);
            string testid = $"{datekey + randomNumber + UserSession.StaffId + patientId}";
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
                            label1.Text = "Please enter a valid result";
                            return;
                        }
                       
                        if (!int.TryParse(resultval, out int number))
                        {
                            label1.Text = "Please enter the test result in numbers";
                            return;
                        }
                        if (number < 20 || number > 400)
                        {
                            label1.Text = "Please enter a valid test result";
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

                        string doclin = $"https://focusnet.works/TrustWellLab/uploads/{filename}";

                        if (string.IsNullOrWhiteSpace(filename))
                        {
                            MessageBox.Show("Please select a file to upload.");
                            return;
                        }

                        string updateQueryRepo = @"UPDATE LabTests SET Report = @Report WHERE LabTID = @LabID";

                        MySqlParameter[] reportparam = new MySqlParameter[]
                        {
                            new MySqlParameter("@Report", doclin),
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

                    try
                    {
                        string filePath = uploadfilepath;

                        if (!File.Exists(filePath))
                        {
                            MessageBox.Show("File does not exist: " + filePath);
                            return;
                        }

                        string uploadUrl = "https://focusnet.works/TrustWellLab/upload.php";

                        using (var client = new HttpClient())
                        using (var form = new MultipartFormDataContent())
                        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            var fileContent = new StreamContent(fileStream);
                            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                            form.Add(fileContent, "file", Path.GetFileName(filePath));

                            var response = await client.PostAsync(uploadUrl, form);
                            string responseContent = await response.Content.ReadAsStringAsync();

                            if (!response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Upload failed: " + responseContent);
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Upload Error: " + ex.Message);
                        return;
                    }

                    // send email to patient 

                    try
                    {
                        string filePath = uploadfilepath;

                        if (!File.Exists(filePath))
                        {
                            MessageBox.Show("File not found for email : " + filePath);
                            return;
                        }

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(patientEmail, "TrustWell Hospital");
                        mail.To.Add(patientEmail);
                        mail.Subject = "Your Lab Test Report from TrustWell Hospital";
                        mail.IsBodyHtml = true;

                        string body = $@"
                        <html>
                        <body style=""margin:0; padding:0; font-family:Arial, sans-serif; background-color:#f4f4f4;"">
                          <table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"" style=""background-color:#ffffff; margin-top:30px; border-radius:8px; box-shadow:0 0 10px rgba(0,0,0,0.1);"">
                            <tr>
                              <td style=""padding: 20px 30px 10px 30px;"">
                                <h2 style=""color:#2c3e50;"">Your Lab Reports {nameoftest} ID <span style=""color:#2980b9;"">{testid}</span></h2>
                              </td>
                            </tr>
                            <tr>
                              <td style=""padding: 0px 30px 20px 30px; color:#555555; font-size: 15px; line-height: 1.6;"">
                                <p>Dear Valued Patient {PatientName},</p>
                                <p>Thank you for choosing <strong>Trust Well Hospital</strong> for your healthcare needs.</p>
                                <p>Your lab report is now ready and has been attached to this email in PDF format for your review.</p>
                                <p><strong>Please do not reply</strong> to this email.</p>
                                <p>If you have any questions or concerns regarding your report, feel free to contact us at:</p>
                                <p style=""color:#2980b9;""><strong>labtrustwell@gmail.com</strong></p>
                                <p>If you need further assistance, please contact our laboratory or your attending physician at your earliest convenience.</p>
                                <p><em>This is an automatically generated email and does not require a signature. Terms and conditions apply.</em></p>
                                <p>Thank you.<br>
                                Best regards,<br>
                                <strong>Trust Well Hospital</strong><br>
                                0113475984<br> 
                            <a href=""http://www.trustwellhospital.com"" style=""color:#2980b9; text-decoration:none;"">www.trustwellhospital.com</a></p>
                              </td>
                            </tr>
                          </table>
                        </html>
                        ";

                        mail.Body = body;
                        mail.Attachments.Add(new Attachment(filePath));

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("kusumindapabasara@gmail.com", "tppg zuwe nkaa lrsw");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email Sending Failed : " + ex.Message);
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
