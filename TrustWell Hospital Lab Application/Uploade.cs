using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Lab_Application
{
    public partial class Uploade: UserControl
    {
        private Home amainForm;
        private int patientId;
        public Uploade(int patientid, Home mainForm)
        {
            InitializeComponent();
            patientId = patientid;
            amainForm = mainForm;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            amainForm.LoadUserControl(new page1(amainForm));
        }


        // here create the funtions use patientid logics here
    }
}
