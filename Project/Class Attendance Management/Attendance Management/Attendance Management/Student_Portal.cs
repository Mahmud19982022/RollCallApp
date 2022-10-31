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
    public partial class Student_Portal : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Student_Portal()
        {
            InitializeComponent();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {   

            this.Hide();
            Course_Details f4 = new Course_Details();
            f4.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Details f3 = new Student_Details();
            f3.Show();
        
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;
           
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Blue;

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = Color.Blue;

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
            button4.ForeColor = Color.Blue;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result rt = new Result();
            rt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Schedule3 cs = new Class_Schedule3();
            cs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform lf = new Loginform();
            lf.Show();
        }
    }
}
