using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management
{
    public partial class Teacher_Portal : Form
    {
        public Teacher_Portal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result_Uploadcs ru = new Result_Uploadcs();
            ru.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance at = new Attendance();
            at.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform lf = new Loginform();
            lf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Information ti = new Teacher_Information();
            ti.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Schedule4 cs = new Class_Schedule4();
            cs.Show();
        }
    }
}
