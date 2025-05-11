using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Lab_Application
{
   
    public partial class Page2: Form
    {

        private int _patientId;
        public Page2(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }
    }
}
