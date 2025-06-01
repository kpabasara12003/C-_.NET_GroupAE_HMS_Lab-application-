using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;

namespace TrustWell_Hospital_Lab_Application
{
    public partial class Home: Form
    {
        DateTimeUpdater dateTime1 = new DateTimeUpdater();
        public Home()
        {
            InitializeComponent();
           
        }

        
        public void LoadUserControl(UserControl uc)
        {
            panel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);

        }

        public class DateTimeUpdater
        {
            private Timer timer;

            public void StartDateTimeClock(Label Time, Label Date)
            {
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (s, e) =>
                {
                    
                    Time.Text = DateTime.Now.ToString("HH:mm");
                    Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
                };
                timer.Start();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadUserControl(new page1(this));
            this.label1.Text = $"Welcome  {UserSession.Username} ";

            dateTime1.StartDateTimeClock(label3, label5);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            LoadUserControl(new page1(this));

        }

        private void gunaButton1_MouseClick(object sender, MouseEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
