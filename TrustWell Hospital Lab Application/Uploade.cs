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
                        panelone.Visible = false;
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


        // here create the funtions use patientid logics here
    }
}
