using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MySql.Data.MySqlClient;

namespace TrustWell_Hospital_Lab_Application
{
    public partial class page1: UserControl
    {
        public page1()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void LoadLabTests()
        {
            string query = @"SELECT 
                        LabTests.LabTID,
                        Patients.PatientName,
                        Patients.PatientID,
                        Testtypes.TestName,
                        Patients.ContactNumber,
                        Patients.Email
                    FROM 
                        LabTests
                    JOIN 
                        Patients ON LabTests.PatientID = Patients.PatientID
                    JOIN 
                        Testtypes ON LabTests.TestType = Testtypes.TestID
                    WHERE 
                        LabTests.Status = 'Pending'";

            DataTable dt = Database.ExecuteQuery(query, null);
            dataGridView1.DataSource = dt;

                    // if we use button or outer element
            if (!dataGridView1.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Action";
                btn.Text = "Report";
                btn.UseColumnTextForButtonValue = true;
                btn.Name = "Action";
                dataGridView1.Columns.Add(btn);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Action")
            {
                int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);



                Page2 detailsForm = new Page2(patientId);
                detailsForm.Show();
            }
        }

        private void page1_Load(object sender, EventArgs e)
        {
            LoadLabTests();
        }
    }
}
