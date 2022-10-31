using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Attendance_Management
{
    public partial class AdminHome : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Schedule cs = new Class_Schedule();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform lf = new Loginform();
            lf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminstudentinfo si = new adminstudentinfo();
            si.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTeacherInformation ati = new AdminTeacherInformation();
            ati.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
            button4.ForeColor = Color.Blue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = Color.Blue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
        }
    }
}
